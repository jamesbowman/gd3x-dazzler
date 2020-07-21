`default_nettype none

/* verilator lint_off DECLFILENAME */
/* verilator lint_off UNUSED */

module tmds(
  input wire clk,
  input wire [7:0] VD,  // video data (red, green or blue)
  input wire [1:0] CD,  // control data
  input wire VDE,  // video data enable, to choose between CD (when VDE=0) and VD (when VDE=1)
  output reg [9:0] TMDS = 0
);

  wire [3:0] Nb1s =
    {3'b000, VD[0]} +
    {3'b000, VD[1]} +
    {3'b000, VD[2]} +
    {3'b000, VD[3]} +
    {3'b000, VD[4]} +
    {3'b000, VD[5]} +
    {3'b000, VD[6]} +
    {3'b000, VD[7]};
  wire XNOR = (Nb1s > 4'd4) || (Nb1s == 4'd4 && VD[0] == 1'b0);
  reg [8:0] q_m;
  always @(posedge clk) q_m <= {~XNOR, q_m[6:0] ^ VD[7:1] ^ {7{XNOR}}, VD[0]};

  reg [3:0] balance_acc = 0;
  wire [3:0] balance =
    {3'b000, q_m[0]} +
    {3'b000, q_m[1]} +
    {3'b000, q_m[2]} +
    {3'b000, q_m[3]} +
    {3'b000, q_m[4]} +
    {3'b000, q_m[5]} +
    {3'b000, q_m[6]} +
    {3'b000, q_m[7]} - 4'd4;
  wire balance_sign_eq = (balance[3] == balance_acc[3]);
  wire invert_q_m = (balance==0 || balance_acc==0) ? ~q_m[8] : balance_sign_eq;
  wire [3:0] balance_acc_inc = balance - {3'b000, ({q_m[8] ^ ~balance_sign_eq} & ~(balance==0 || balance_acc==0))};
  wire [3:0] balance_acc_new = invert_q_m ? balance_acc-balance_acc_inc : balance_acc+balance_acc_inc;
  wire [9:0] TMDS_data = {invert_q_m, q_m[8], q_m[7:0] ^ {8{invert_q_m}}};
  wire [9:0] TMDS_code = CD[1] ? (CD[0] ? 10'b1010101011 : 10'b0101010100) : (CD[0] ? 10'b0010101011 : 10'b1101010100);

  always @(posedge clk) TMDS <= VDE ? TMDS_data : TMDS_code;
  always @(posedge clk) balance_acc <= VDE ? balance_acc_new : 4'h0;
endmodule

module terc4(
    input wire [3:0] i,
    output reg [9:0] o
);

always @*
  case (i)
    4'b0000: o = 10'b1010011100;
    4'b0001: o = 10'b1001100011;
    4'b0010: o = 10'b1011100100;
    4'b0011: o = 10'b1011100010;
    4'b0100: o = 10'b0101110001;
    4'b0101: o = 10'b0100011110;
    4'b0110: o = 10'b0110001110;
    4'b0111: o = 10'b0100111100;
    4'b1000: o = 10'b1011001100;
    4'b1001: o = 10'b0100111001;
    4'b1010: o = 10'b0110011100;
    4'b1011: o = 10'b1011000110;
    4'b1100: o = 10'b1010001110;
    4'b1101: o = 10'b1001110001;
    4'b1110: o = 10'b0101100011;
    4'b1111: o = 10'b1011000011;
  endcase

endmodule

module video_data(
  input  wire [26:0] dd1,
  input  wire clk,
  output wire [29:0] d);

  wire [7:0] pR;
  wire [7:0] pG;
  wire [7:0] pB;
  wire DE, HSYNC, VSYNC;
  assign {pR, pG, pB, DE, HSYNC, VSYNC} = dd1;
  wire [9:0] TMDS_red, TMDS_green, TMDS_blue;
  tmds encode_R(.clk(clk), .VD(pR), .CD(2'b00)          ,.VDE(DE), .TMDS(TMDS_red));
  tmds encode_G(.clk(clk), .VD(pG), .CD(2'b00)          ,.VDE(DE), .TMDS(TMDS_green));
  tmds encode_B(.clk(clk), .VD(pB), .CD({VSYNC,HSYNC})  ,.VDE(DE), .TMDS(TMDS_blue));
  assign d = {TMDS_red, TMDS_green, TMDS_blue};
endmodule

// Simplifications:
//
// Plenty of room between the HSYNC pulse and start of video, so data island does not overlap HSYNC
// Always insert 3 data packets
//     0 audio sample
//     1 audio sample
//     On a 45-line cycle:
//        00: Audio Clock Regeneration Packet
//        82: AVI InfoFrame
//        83: Source Product Descriptor InfoFrame
//        84: Audio InfoFrame
//

module hdmi(
  input  wire clk,
  input  wire [26:0] dd1,
  output reg [29:0] d);

  reg [26:0] prepipe [0:10];
  always @(posedge clk) begin
    prepipe[0] <= dd1;
    prepipe[1] <= prepipe[0];
    prepipe[2] <= prepipe[1];
    prepipe[3] <= prepipe[2];
    prepipe[4] <= prepipe[3];
    prepipe[5] <= prepipe[4];
    prepipe[6] <= prepipe[5];
    prepipe[7] <= prepipe[6];
    prepipe[8] <= prepipe[7];
    prepipe[9] <= prepipe[8];
    prepipe[10] <= prepipe[9];
  end

  wire DE, HSYNC, VSYNC;
  assign {DE, HSYNC, VSYNC} = prepipe[10][2:0];
  reg HSYNC_;
  reg [10:0] hblank;
  reg [5:0] y;
  wire [5:0] yN = (y == 6'd44) ? 6'd0 : (y + 6'd1);
  always @(posedge clk) begin
    HSYNC_ <= HSYNC;
    if (~HSYNC_ & HSYNC) begin
      // $display("DE edge %d", y);
      y <= yN;
    end
    if (HSYNC)
      hblank <= 0;
    else
      hblank <= hblank + 1;
  end

  reg [23:0] pkt_hdr;
  reg [7:0] hecc;

  reg [55:0] pkt_bch;
  reg [7:0] pecc;

  wire video_guards   = ~DE & prepipe[8][2];
  wire video_preamble = ~DE & ~video_guards & prepipe[0][2];
  wire data_preamble  = ~DE & ~HSYNC & (hblank < 11'd8);
  wire data_guard     = ((11'd8 <= hblank) & (hblank < 11'd10)) | ((11'd42 <= hblank) & (hblank < 11'd44));
  wire data_island    = (11'd10 <= hblank) & (hblank < 11'd42);
  wire [4:0] dib = hblank[4:0] - 5'd10;

  wire [9:0] dp0 = VSYNC ? 10'b0101010100 : 10'b1101010100;
  wire [9:0] dg0 = VSYNC ? 10'b0101100011 : 10'b1010001110;

  wire [29:0] o0;                                             // video data
  wire [29:0] o1 =  30'b_1011001100_0100110011_1011001100;    // video guard
  wire [29:0] o2 =  30'b_1101010100_0010101011_1101010100;    // video preamble
  wire [29:0] o3 = {20'b_0010101011_0010101011, dp0};         // data preamble
  wire [29:0] o4 = {20'b_0100110011_0100110011, dg0};         // data guard
  wire [29:0] o5;                                             // TERC

  wire bh = &dib[4:3] ? hecc[0] : pkt_hdr[0];
  wire [7:0] next_hecc = {1'b0, hecc[7:1]} ^ (((hecc[0] ^ bh)) ? 8'b10000011 : 8'd0);

  wire bp0 = &dib[4:2] ? pecc[0] : pkt_bch[0];
  wire bp1 = &dib[4:2] ? pecc[1] : pkt_bch[1];
  wire [7:0] pec0      = {1'b0, pecc[7:1]} ^ (((pecc[0] ^ bp0)) ? 8'b10000011 : 8'd0);
  wire [7:0] next_pecc = {1'b0, pec0[7:1]} ^ (((pec0[0] ^ bp1)) ? 8'b10000011 : 8'd0);

  terc4 _terc0 (.i({1'b1, bh, VSYNC, HSYNC}), .o(o5[9:0]));
  terc4 _terc1 (.i({3'b000, bp0}),            .o(o5[19:10]));
  terc4 _terc2 (.i({3'b000, bp1}),            .o(o5[29:20]));

  video_data _e (.clk(clk), .dd1(prepipe[9]), .d(o0)); // has 1 clk latency, so use [9]

  always @*
    if (data_island)
      d = o5;
    else if (data_guard)
      d = o4;
    else if (data_preamble)
      d = o3;
    else if (video_preamble)
      d = o2;
    else if (video_guards)
      d = o1;
    else
      d = o0;

  always @(posedge clk) begin
    if (dib == 5'd31) begin
      case (y)
      6'd1:
        begin
          hecc <= 8'h00;
          pkt_hdr <= 24'h0d0282;
          pecc <= 8'h00;
          pkt_bch <= 56'h00_04_00_08_00_63;
        end
      default:
        begin
          hecc <= 0;
          pkt_hdr <= 0;
          pecc <= 0;
          pkt_bch <= 0;
        end
      endcase
    end else begin
      pkt_hdr <= {1'b0, pkt_hdr[23:1]};
      pkt_bch <= {2'b0, pkt_bch[55:2]};
      hecc <= next_hecc;
      pecc <= next_pecc;
    end
  end

endmodule

/* verilator lint_on UNUSED */
/* verilator lint_on DECLFILENAME */

