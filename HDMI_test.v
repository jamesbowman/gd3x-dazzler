// (c) fpga4fun.com & KNJN LLC 2013

////////////////////////////////////////////////////////////////////////
module HDMI_front(
	input wire pixclk,
        output wire [29:0] d);

////////////////////////////////////////////////////////////////////////
reg [10:0] CounterX, CounterY;
reg hSync, vSync, DrawArea;

// `define HCYCLE  800
// `define HSIZE   640
// `define HPORCH  16
// `define HPULSE  96
// `define VCYCLE  525
// `define VSIZE   480
// `define VPORCH  10
// `define VPULSE  2

// 720x480 with 27 MHz pclk
// `define HCYCLE  858
// `define HSIZE   720
// `define HPORCH  16
// `define HPULSE  62
// `define VCYCLE  525
// `define VSIZE   480
// `define VPORCH  9
// `define VPULSE  6

// 800x600 with 36 MHz pclk
`define HCYCLE  1024
`define HSIZE   800
`define HPORCH  24
`define HPULSE  72
`define VCYCLE  625
`define VSIZE   600
`define VPORCH  1
`define VPULSE  2

// 800x600 with 40 MHz pclk
// `define HCYCLE  1056
// `define HSIZE   800
// `define HPORCH  40
// `define HPULSE  128
// `define VCYCLE  628
// `define VSIZE   600
// `define VPORCH  1
// `define VPULSE  4

// 800x600 with 50 MHz pclk
// `define HCYCLE  1040
// `define HSIZE   800
// `define HPORCH  56
// `define HPULSE  120
// `define VCYCLE  666
// `define VSIZE   600
// `define VPORCH  37
// `define VPULSE  6

// 1280x720 with 74 MHz pclk
// `define HCYCLE  1650
// `define HSIZE   1280
// `define HPORCH  110
// `define HPULSE  40
// `define VCYCLE  750
// `define VSIZE   720
// `define VPORCH  5
// `define VPULSE  5

always @(posedge pixclk) DrawArea <= (CounterX < `HSIZE) && (CounterY<`VSIZE);

always @(posedge pixclk) CounterX <= (CounterX==(`HCYCLE - 1)) ? 0 : CounterX+1;
always @(posedge pixclk) if(CounterX==(`HCYCLE - 1)) CounterY <= (CounterY==(`VCYCLE - 1)) ? 0 : CounterY+1;

always @(posedge pixclk) hSync <= (CounterX>=(`HSIZE + `HPORCH)) && (CounterX<(`HSIZE + `HPORCH + `HPULSE));
always @(posedge pixclk) vSync <= (CounterY>=(`VSIZE + `VPORCH)) && (CounterY<(`VSIZE + `VPORCH + `VPULSE));

////////////////
wire [7:0] W = {8{CounterX[7:0]==CounterY[7:0]}};
wire [7:0] A = {8{CounterX[7:5]==3'h2 && CounterY[7:5]==3'h2}};
reg [7:0] red, green, blue;
always @(posedge pixclk) red <= ({CounterX[5:0] & {6{CounterY[4:3]==~CounterX[4:3]}}, 2'b00} | W) & ~A;
always @(posedge pixclk) green <= (CounterX[7:0] & {8{CounterY[6]}} | W) & ~A;
always @(posedge pixclk) blue <= CounterY[7:0] | W | A;

////////////////////////////////////////////////////////////////////////
wire [9:0] TMDS_red, TMDS_green, TMDS_blue;
TMDS_encoderA encode_R(.clk(pixclk), .VD(red  ), .CD(2'b00)        , .VDE(DrawArea), .TMDS(TMDS_red));
TMDS_encoderA encode_G(.clk(pixclk), .VD(green), .CD(2'b00)        , .VDE(DrawArea), .TMDS(TMDS_green));
TMDS_encoderA encode_B(.clk(pixclk), .VD(blue ), .CD({vSync,hSync}), .VDE(DrawArea), .TMDS(TMDS_blue));

assign d = {TMDS_red, TMDS_green, TMDS_blue};
endmodule

module HDMI_back(
	input wire pixclk,  // 25MHz
	input wire pixclk2,  // 25MHz
        input wire [29:0] d,
	output wire [2:0] TMDSp, TMDSn,
	output wire TMDSp_clock, TMDSn_clock
);

wire [9:0] TMDS_red, TMDS_green, TMDS_blue;
assign {TMDS_red, TMDS_green, TMDS_blue} = d;

////////////////////////////////////////////////////////////////////////
wire clk_TMDS, DCM_TMDS_CLKFX;  // 25MHz x 10 = 250MHz
DCM_SP #(.CLKFX_MULTIPLY(10)) DCM_TMDS_inst(.CLKIN(pixclk), .CLKFX(DCM_TMDS_CLKFX), .RST(1'b0));
BUFG BUFG_TMDSp(.I(DCM_TMDS_CLKFX), .O(clk_TMDS));

////////////////////////////////////////////////////////////////////////
reg [3:0] TMDS_mod10=0;  // modulus 10 counter
reg [9:0] TMDS_shift_red=0, TMDS_shift_green=0, TMDS_shift_blue=0;
reg TMDS_shift_load=0;
always @(posedge clk_TMDS) TMDS_shift_load <= (TMDS_mod10==4'd9);

always @(posedge clk_TMDS)
begin
	TMDS_shift_red   <= TMDS_shift_load ? TMDS_red   : TMDS_shift_red  [9:1];
	TMDS_shift_green <= TMDS_shift_load ? TMDS_green : TMDS_shift_green[9:1];
	TMDS_shift_blue  <= TMDS_shift_load ? TMDS_blue  : TMDS_shift_blue [9:1];	
	TMDS_mod10 <= (TMDS_mod10==4'd9) ? 4'd0 : TMDS_mod10+4'd1;
end

OBUFDS OBUFDS_red  (.I(TMDS_shift_red  [0]), .O(TMDSp[2]), .OB(TMDSn[2]));
OBUFDS OBUFDS_green(.I(TMDS_shift_green[0]), .O(TMDSp[1]), .OB(TMDSn[1]));
OBUFDS OBUFDS_blue (.I(TMDS_shift_blue [0]), .O(TMDSp[0]), .OB(TMDSn[0]));
OBUFDS OBUFDS_clock(.I(pixclk2), .O(TMDSp_clock), .OB(TMDSn_clock));

endmodule


////////////////////////////////////////////////////////////////////////
module TMDS_encoderA(
	input wire clk,
	input wire [7:0] VD,  // video data (red, green or blue)
	input wire [1:0] CD,  // control data
	input wire VDE,  // video data enable, to choose between CD (when VDE=0) and VD (when VDE=1)
	output reg [9:0] TMDS = 0
);

wire [3:0] Nb1s = VD[0] + VD[1] + VD[2] + VD[3] + VD[4] + VD[5] + VD[6] + VD[7];
wire XNOR = (Nb1s>4'd4) || (Nb1s==4'd4 && VD[0]==1'b0);
wire [8:0] q_m = {~XNOR, q_m[6:0] ^ VD[7:1] ^ {7{XNOR}}, VD[0]};

reg [3:0] balance_acc = 0;
wire [3:0] balance = q_m[0] + q_m[1] + q_m[2] + q_m[3] + q_m[4] + q_m[5] + q_m[6] + q_m[7] - 4'd4;
wire balance_sign_eq = (balance[3] == balance_acc[3]);
wire invert_q_m = (balance==0 || balance_acc==0) ? ~q_m[8] : balance_sign_eq;
wire [3:0] balance_acc_inc = balance - ({q_m[8] ^ ~balance_sign_eq} & ~(balance==0 || balance_acc==0));
wire [3:0] balance_acc_new = invert_q_m ? balance_acc-balance_acc_inc : balance_acc+balance_acc_inc;
wire [9:0] TMDS_data = {invert_q_m, q_m[8], q_m[7:0] ^ {8{invert_q_m}}};
wire [9:0] TMDS_code = CD[1] ? (CD[0] ? 10'b1010101011 : 10'b0101010100) : (CD[0] ? 10'b0010101011 : 10'b1101010100);

always @(posedge clk) TMDS <= VDE ? TMDS_data : TMDS_code;
always @(posedge clk) balance_acc <= VDE ? balance_acc_new : 4'h0;
endmodule


////////////////////////////////////////////////////////////////////////
