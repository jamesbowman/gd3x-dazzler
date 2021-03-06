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
  /* verilator lint_off UNOPTFLAT */
  wire [8:0] q_m;
  /* verilator lint_on UNOPTFLAT */
  assign q_m[0] = VD[0];
  assign q_m[1] = q_m[0] ^ VD[1] ^ XNOR;
  assign q_m[2] = q_m[1] ^ VD[2] ^ XNOR;
  assign q_m[3] = q_m[2] ^ VD[3] ^ XNOR;
  assign q_m[4] = q_m[3] ^ VD[4] ^ XNOR;
  assign q_m[5] = q_m[4] ^ VD[5] ^ XNOR;
  assign q_m[6] = q_m[5] ^ VD[6] ^ XNOR;
  assign q_m[7] = q_m[6] ^ VD[7] ^ XNOR;
  assign q_m[8] = ~XNOR;

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
  output reg [29:0] d,
  input  wire audio_w,
  input  wire [31:0] audio);

  reg running;
  always @(posedge clk) begin
    running <= running | dd1[0];  // come to life as soon as VSYNC==1
  end

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
  reg [10:0] x;
  reg [5:0] y;
  wire [5:0] yN = (y == 6'd44) ? 6'd0 : (y + 6'd1);
  always @(posedge clk) begin
    HSYNC_ <= HSYNC;
    if (~HSYNC_ & HSYNC) begin
      // $display("DE edge %d", y);
      y <= yN;
    end
    if (HSYNC)
      x <= 11'd22;
    else
      x <= x + 1;
  end

  reg [23:0] pkt_hdr;
  reg [7:0] hecc;

  reg [55:0] pkt_bch;
  reg [7:0] pecc;

  wire video_guards   = ~DE & prepipe[8][2];
  wire video_preamble = ~DE & ~video_guards & prepipe[0][2];
  wire data_preamble  = ~DE & ~HSYNC & (x < 11'd30);
  wire data_guard     = (x == 11'd30) |
                        (x == 11'd31) |
                        (x == 11'd128) |
                        (x == 11'd129);
  wire data_island    = (11'd32 <= x) & (x < 11'd128);

  wire [9:0] dp0 = VSYNC ? 10'b0101010100 : 10'b1101010100;
  wire [9:0] dg0 = VSYNC ? 10'b0101100011 : 10'b1010001110;

  wire [29:0] o0;                                             // video data
  wire [29:0] o1 =  30'b_1011001100_0100110011_1011001100;    // video guard
  wire [29:0] o2 =  30'b_1101010100_0010101011_1101010100;    // video preamble
  wire [29:0] o3 = {20'b_0010101011_0010101011, dp0};         // data preamble
  wire [29:0] o4 = {20'b_0100110011_0100110011, dg0};         // data guard
  wire [29:0] o5;                                             // TERC

  wire bh = &x[4:3] ? hecc[0] : pkt_hdr[0];
  wire [7:0] next_hecc = {1'b0, hecc[7:1]} ^ (((hecc[0] ^ bh)) ? 8'b10000011 : 8'd0);

  wire bp0 = &x[4:2] ? pecc[0] : pkt_bch[0];
  wire bp1 = &x[4:2] ? pecc[1] : pkt_bch[1];
  wire [7:0] pec0      = {1'b0, pecc[7:1]} ^ (((pecc[0] ^ bp0)) ? 8'b10000011 : 8'd0);
  wire [7:0] next_pecc = {1'b0, pec0[7:1]} ^ (((pec0[0] ^ bp1)) ? 8'b10000011 : 8'd0);

  wire frame = (x != 11'd32);
  reg dup4 = 0;     // Audio clock packet duplicates the data 4 times
  terc4 _terc0 (.i({frame, bh, VSYNC, HSYNC}), .o(o5[9:0]));
  terc4 _terc1 (.i({dup4 ? {3{bp0}} : 3'b000, bp0}), .o(o5[19:10]));
  terc4 _terc2 (.i({dup4 ? {3{bp1}} : 3'b000, bp1}), .o(o5[29:20]));

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


  wire audio_r = running & (x[4:0] == 5'd31) & (x[10:5] <= 6'd1);
  wire [7:0] csb;
  wire [7:0] csbN = (csb == 8'd191) ? 8'd0 : (csb + 8'd1);

  
  localparam STSZ = 2 + 16 + 16 + 16 + 16 + 8;
  reg [STSZ - 1:0] audio_state = {2'd0, 32'd0, 16'h2222, 16'h1111, 8'd0};
  reg [STSZ - 1:0] audio_stateN;
  wire [1:0] fullness;
  wire [31:0] sample0, sample1;
  assign {fullness, sample1, sample0, csb} = audio_state;

  always @*
    casez ({fullness, audio_w, audio_r})

//      F     W     R                      F     S1       S0    CSB

    {2'd0, 1'b0, 1'b1}: audio_stateN = {2'd0, 32'bx,   32'bx,   csb};
    {2'd0, 1'b1, 1'b?}: audio_stateN = {2'd1, 32'bx,   audio,   csb};

    {2'd1, 1'b0, 1'b1}: audio_stateN = {2'd0, 32'bx,   32'bx,   csbN};
    {2'd1, 1'b1, 1'b0}: audio_stateN = {2'd2, audio,   sample0, csb};
    {2'd1, 1'b1, 1'b1}: audio_stateN = {2'd1, 32'bx,   audio,   csbN};

    {2'd2, 1'b0, 1'b1}: audio_stateN = {2'd1, 32'bx,   sample1, csbN};
    {2'd2, 1'b1, 1'b0}: audio_stateN = {2'd2, audio,   sample0, csb};
    {2'd2, 1'b1, 1'b1}: audio_stateN = {2'd2, audio,   sample1, csbN};

    default:
          audio_stateN = audio_state;
    endcase

  reg audio_have;
  reg [15:0] lsample, rsample;
  always @(posedge clk) begin
    audio_state <= audio_stateN;
    if (audio_r) begin
      audio_have <= (fullness != 2'd0);
      {rsample, lsample} <= sample0;
    end
  end

  wire [191:0] csbL = 192'h000000000000000000000000000000000000000202100004;
  wire [191:0] csbR = 192'h000000000000000000000000000000000000000202200004;
  wire Cl = csbL[csb], Cr = csbR[csb];
  wire Pl = ^{lsample, Cl}, Pr = ^{rsample, Cr};
  wire [55:0] audio_packet = {
    Pr, Cr, 2'b00, Pl, Cl, 2'b00,
    rsample,
    8'h00,
    lsample,
    8'h00
    };

  always @(posedge clk) begin
    if (running & (x[4:0] == 5'd31)) begin

      hecc <= 8'h00;
      pecc <= 8'h00;

      case (x[6:5])

      2'd0, 2'd1:
        begin
          pkt_hdr <= {
            (csb == 0) ? 8'b00010000 : 8'd0,
            8'h01,
            audio_have ? 8'h02 : 8'h00};
          pkt_bch <= audio_packet;
          dup4 <= 0;
        end
        
      2'd2:
        case (y)
        6'd0:
          begin
            pkt_hdr <= 24'h000001;
            pkt_bch <= 56'h18_00_0a_22_01_00;
            dup4 <= 1;
          end
        6'd1:
          begin
            pkt_hdr <= 24'h0d0282;
            pkt_bch <= 56'h00_04_00_08_00_63;
            dup4 <= 0;
          end
        6'd2:
          begin
            pkt_hdr <= 24'h0a0184;
            pkt_bch <= 56'h00_00_00_00_01_70;
            dup4 <= 0;
          end
        default:
          begin
            pkt_hdr <= 0;
            pkt_bch <= 0;
            dup4 <= 0;
          end
        endcase

      default:
        begin
          pkt_hdr <= 0;
          pkt_bch <= 0;
          dup4 <= 0;
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

