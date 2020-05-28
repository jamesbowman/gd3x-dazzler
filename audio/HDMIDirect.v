// (c) fpga4fun.com & KNJN LLC 2013
`default_nettype none

////////////////////////////////////////////////////////////////////////
module HDMIDirectV(
    input wire pixclk, // 25MHz
    input wire resetq,
    input wire [23:0] videobus,
    input wire [15:0] insample,
    output wire [29:0] d,
    output wire [15:0] debug
);

////////////////////////////////////////////////////////////////////////
reg [10:0] CounterX, CounterY;
reg hSync, vSync, DrawArea;
reg tercData;
reg [3:0] dataChannel0;
reg [3:0] dataChannel1;
reg [3:0] dataChannel2;
reg [3:0] preamble;
reg dataGuardBand;
reg videoGuardBand;
reg [23:0] packetHeader;
reg [23:0] packetHeader2;
reg [7:0]  bchHdr;
reg [55:0] subpacket [3:0];
reg [55:0] subpacket2[3:0];
reg [7:0]  bchCode [3:0];
reg [191:0] channelStatus;
reg [7:0] channelStatusIdx;
reg tercDataDelayed;
reg videoGuardBandDelayed;
reg dataGuardBandDelayed;
reg [24:0] samplesNeeded;
reg [15:0] audioTimer;
reg [9:0] audioSamples;
reg [15:0] sample;
reg sampleDir;

initial
begin
 CounterX=0;
 CounterY=0;
 hSync=0;
 vSync=0;
 DrawArea=0;
end

`ifdef RES640_480
`define DISPLAY_WIDTH   640
`define DISPLAY_HEIGHT  480
`define FULL_WIDTH      768
`define FULL_HEIGHT     528
`define H_FRONT_PORCH   16
`define H_SYNC          96
`define V_FRONT_PORCH   10 
`define V_SYNC          2
`define AUDIO_CYCLE     750
`else
`define DISPLAY_WIDTH   1280
`define DISPLAY_HEIGHT  720
`define FULL_WIDTH      1650
`define FULL_HEIGHT     750
`define H_FRONT_PORCH   110
`define H_SYNC          40
`define V_FRONT_PORCH   5
`define V_SYNC          5
`define AUDIO_CYCLE     1500
`endif

always @(posedge pixclk) DrawArea <= (CounterX < `DISPLAY_WIDTH) && (CounterY < `DISPLAY_HEIGHT);

always @(posedge pixclk) hSync <= ((`DISPLAY_WIDTH +`H_FRONT_PORCH) <= CounterX) && (CounterX < (`DISPLAY_WIDTH +`H_FRONT_PORCH + `H_SYNC));
always @(posedge pixclk) vSync <= ((`DISPLAY_HEIGHT + `V_FRONT_PORCH) <= CounterY) && (CounterY < (`DISPLAY_HEIGHT + `V_FRONT_PORCH + `V_SYNC));

`define DATA_START      (`DISPLAY_WIDTH + `H_FRONT_PORCH + 4)
`define DATA_PREAMBLE   8
`define DATA_GUARDBAND  2
`define DATA_SIZE       32
`define VIDEO_PREAMBLE  8
`define VIDEO_GUARDBAND 2
`define CTL_END         (`FULL_WIDTH-`VIDEO_PREAMBLE-`VIDEO_GUARDBAND)

function [7:0] ECCcode;
    input [7:0] code;
    input bita;
    input mask;
    begin
        ECCcode = (code << 1) ^ (((code[7]^bita) && mask) ? (1 + (1 << 6) + (1 << 7)):0);
    end
endfunction

function ECC;
    input [7:0] code;
    input bita;
    input mask;
    begin
        ECC = mask ? bita:code[7];
    end
endfunction

task ECCu;
    inout [7:0] code;
    input bita;
    input mask;
    begin
        code <= ECCcode(code, bita, mask);
    end
endtask

function ECC2a;
    input [7:0] code;
    input bita;
    input bitb;
    input mask;
    begin
        ECC2a = mask ? bita:code[7];
    end
endfunction

function ECC2b;
    input [7:0] code;
    input bita;
    input bitb;
    input mask;
    begin
        ECC2b = mask ? bitb:(code[6]^(((code[7]^bita) && mask) ? 1'b1:1'b0));
    end
endfunction

task ECC2u;
    inout [7:0] code;
    input bita;
    input bitb;
    input mask;
    begin
        code <= ECCcode(ECCcode(code, bita, mask), bitb, mask);
    end
endtask
// See IEC 60958, e.g. https://tech.ebu.ch/docs/tech/tech3250.pdf
localparam [191:0] CSB = 192'h00_00_00_00_00_00_00_00_00_00_00_00_00_00_00_00_00_00_00_C2_03_00_40_04;
wire [55:0] CSBbit = CSB[channelStatusIdx] ? 56'hCC000000000000 : 56'h0;

// (25e6 * 0x1000 / 0x5dc0) / 128 = 33333.33
// wire [19:0] N   = 20'h1000;
// wire [19:0] CTS = 20'h5dc0;
wire [19:0] N = 20'h0;
wire [19:0] CTS = 20'h0;

wire [55:0] audio_clock_regeneration_subpacket = {    // HDMI - spec p.64
  N[7:0], N[15:8], 4'd0, N[19:16],
  CTS[7:0], CTS[15:8], 4'd0, CTS[19:16],
  8'h00};

wire [4:0] doffset = (CounterX - (`DATA_START + `DATA_PREAMBLE + `DATA_GUARDBAND));

reg [5:0] toggle;

reg [15:0] sinx;
always @*
  case (toggle)
`include "sintab.i"
default: sinx <= 0;
  endcase

always @(negedge resetq or posedge pixclk)
  if (!resetq) begin
      dataChannel0 <= 0;
      dataChannel1 <= 0;
      dataChannel2 <= 0;
      videoGuardBand <= 0;
      packetHeader <= 0;
      packetHeader2 <= 0;
      bchHdr <= 0;
      subpacket[0] <= 0;
      subpacket[1] <= 0;
      subpacket[2] <= 0;
      subpacket[3] <= 0;
      subpacket2[0] <= 0;
      subpacket2[1] <= 0;
      subpacket2[2] <= 0;
      subpacket2[3] <= 0;
      bchCode[0] <= 0;
      bchCode[1] <= 0;
      bchCode[2] <= 0;
      bchCode[3] <= 0;
      channelStatus <= 0;
      channelStatusIdx <= 0;
      tercData <= 0;
      samplesNeeded <= 0;
      sample <= 0;
      sampleDir <= 0;
      audioSamples <= 0;
      audioTimer <= 0;
      toggle <= 0;
      preamble <= 0;
      dataGuardBand <= 0;
  end else begin
      if (audioTimer == (`AUDIO_CYCLE - 1)) begin
          audioTimer <= 0;
          toggle <= toggle + 6'b1;
          sample <= insample;
          samplesNeeded <= samplesNeeded + 1;
      end else begin
          audioTimer <= audioTimer + 1;
      end

      if (CounterX >= `DATA_START)
      begin
          if (CounterX < (`DATA_START + `DATA_PREAMBLE))
          begin
              preamble <= 'b0101;
          end
          else if (CounterX < (`DATA_START + `DATA_PREAMBLE + `DATA_GUARDBAND))
          begin
              tercData <= 1;
              dataGuardBand <= 1;
              dataChannel0 <= {1'b1, 1'b1, vSync, hSync};
              preamble <= 0;
              if (audioSamples[4:0] == 0) begin
                  packetHeader <= 24'h000001;   // audio clock regeneration packet
                  subpacket[0] <= audio_clock_regeneration_subpacket;
                  subpacket[1] <= audio_clock_regeneration_subpacket;
                  subpacket[2] <= audio_clock_regeneration_subpacket;
                  subpacket[3] <= audio_clock_regeneration_subpacket;
              end else begin
                  if (!CounterY[0]) begin
                      packetHeader <= 24'h0D0282;   // infoframe AVI packet
                      subpacket[0] <= 56'h0000010019107b;
                      subpacket[1] <= 56'h0501000005bf00;
                      subpacket[2] <= 56'h00000000000000;
                      subpacket[3] <= 56'h00000000000000;
                  end else begin
                      packetHeader <= 24'h0A0184;   // infoframe audio packet
                      subpacket[0] <= 56'h00000000001160;
                      subpacket[1] <= 56'h00000000000000;
                      subpacket[2] <= 56'h00000000000000;
                      subpacket[3] <= 56'h00000000000000;
                  end
              end
              
              if (packetHeader2 == 0 || audioSamples[4:0]!=0) begin
                  if (samplesNeeded>0) begin
                      if (packetHeader2 == 0) begin
                          packetHeader2 <= 24'h000102|(channelStatusIdx == 0 ? 24'h100000:24'h0);   // audio sample
                          subpacket2[0] <= ((sample << 8)|(sample << 32)|((^sample) ? 56'h88000000000000:56'h0))^CSBbit;
                          subpacket2[1] <= 56'h99000000000000;
                          subpacket2[2] <= 56'h99000000000000;
                          subpacket2[3] <= 56'h99000000000000;
                      end else begin
                          packetHeader2 <= packetHeader2|24'h000200|(channelStatusIdx == 0 ? 24'h200000:24'h0);
                          subpacket2[1] <= ((sample << 8)|(sample << 32)|((^sample) ? 56'h88000000000000:56'h0))^CSBbit;
                      end
                      if (channelStatusIdx < 191)
                          channelStatusIdx <= channelStatusIdx + 1;
                      else
                          channelStatusIdx <= 0;
                      samplesNeeded <= samplesNeeded - 1 + ((audioTimer == (`AUDIO_CYCLE - 1)) ? 1:0);
                      audioSamples <= audioSamples + 1;
                  end
              end
              
              bchHdr <= 0;
              bchCode[0] <= 0;
              bchCode[1] <= 0;
              bchCode[2] <= 0;
              bchCode[3] <= 0;
          end
          else if (CounterX < (`DATA_START + `DATA_PREAMBLE + `DATA_GUARDBAND + `DATA_SIZE))
          begin
              dataGuardBand <= 0;
              dataChannel0 <= {doffset ? 1'b1:1'b0, ECC(bchHdr, packetHeader[0], doffset < 24 ? 1'b1:1'b0), vSync, hSync};
              dataChannel1 <= {
                  ECC2a(bchCode[3], subpacket[3][0], subpacket[3][1], (doffset < 5'd28) ? 1'b1:1'b0),
                  ECC2a(bchCode[2], subpacket[2][0], subpacket[2][1], (doffset < 5'd28) ? 1'b1:1'b0),
                  ECC2a(bchCode[1], subpacket[1][0], subpacket[1][1], (doffset < 5'd28) ? 1'b1:1'b0),
                  ECC2a(bchCode[0], subpacket[0][0], subpacket[0][1], (doffset < 5'd28) ? 1'b1:1'b0)
                  };
              dataChannel2 <= {
                  ECC2b(bchCode[3], subpacket[3][0], subpacket[3][1], ((doffset < 5'd28) ? 1'b1:1'b0)),
                  ECC2b(bchCode[2], subpacket[2][0], subpacket[2][1], ((doffset < 5'd28) ? 1'b1:1'b0)),
                  ECC2b(bchCode[1], subpacket[1][0], subpacket[1][1], ((doffset < 5'd28) ? 1'b1:1'b0)),
                  ECC2b(bchCode[0], subpacket[0][0], subpacket[0][1], ((doffset < 5'd28) ? 1'b1:1'b0))
                  };
              ECCu(bchHdr, packetHeader[0], doffset < 24 ? 1'b1:1'b0);
              ECC2u(bchCode[3], subpacket[3][0], subpacket[3][1], doffset < 28 ? 1'b1:1'b0);
              ECC2u(bchCode[2], subpacket[2][0], subpacket[2][1], doffset < 28 ? 1'b1:1'b0);
              ECC2u(bchCode[1], subpacket[1][0], subpacket[1][1], doffset < 28 ? 1'b1:1'b0);
              ECC2u(bchCode[0], subpacket[0][0], subpacket[0][1], doffset < 28 ? 1'b1:1'b0);
              packetHeader <= packetHeader[23:1];
              subpacket[0] <= subpacket[0][55:2];
              subpacket[1] <= subpacket[1][55:2];
              subpacket[2] <= subpacket[2][55:2];
              subpacket[3] <= subpacket[3][55:2];
          end
          else if (CounterX < (`DATA_START + `DATA_PREAMBLE + `DATA_GUARDBAND + `DATA_SIZE + `DATA_SIZE))
          begin
              dataChannel0 <= {1'b1, ECC(bchHdr, packetHeader2[0], doffset < 24 ? 1'b1:1'b0), vSync, hSync};
              dataChannel1 <= {
                  ECC2a(bchCode[3], subpacket2[3][0], subpacket2[3][1], (doffset < 5'd28) ? 1'b1:1'b0),
                  ECC2a(bchCode[2], subpacket2[2][0], subpacket2[2][1], (doffset < 5'd28) ? 1'b1:1'b0),
                  ECC2a(bchCode[1], subpacket2[1][0], subpacket2[1][1], (doffset < 5'd28) ? 1'b1:1'b0),
                  ECC2a(bchCode[0], subpacket2[0][0], subpacket2[0][1], (doffset < 5'd28) ? 1'b1:1'b0)
                  };
              dataChannel2 <= {
                  ECC2b(bchCode[3], subpacket2[3][0], subpacket2[3][1], ((doffset < 5'd28) ? 1'b1:1'b0)),
                  ECC2b(bchCode[2], subpacket2[2][0], subpacket2[2][1], ((doffset < 5'd28) ? 1'b1:1'b0)),
                  ECC2b(bchCode[1], subpacket2[1][0], subpacket2[1][1], ((doffset < 5'd28) ? 1'b1:1'b0)),
                  ECC2b(bchCode[0], subpacket2[0][0], subpacket2[0][1], ((doffset < 5'd28) ? 1'b1:1'b0))
                  };
              ECCu(bchHdr, packetHeader2[0], doffset < 24 ? 1'b1:1'b0);
              ECC2u(bchCode[3], subpacket2[3][0], subpacket2[3][1], doffset < 28 ? 1'b1:1'b0);
              ECC2u(bchCode[2], subpacket2[2][0], subpacket2[2][1], doffset < 28 ? 1'b1:1'b0);
              ECC2u(bchCode[1], subpacket2[1][0], subpacket2[1][1], doffset < 28 ? 1'b1:1'b0);
              ECC2u(bchCode[0], subpacket2[0][0], subpacket2[0][1], doffset < 28 ? 1'b1:1'b0);
              packetHeader2 <= packetHeader2[23:1];
              subpacket2[0] <= subpacket2[0][55:2];
              subpacket2[1] <= subpacket2[1][55:2];
              subpacket2[2] <= subpacket2[2][55:2];
              subpacket2[3] <= subpacket2[3][55:2];
          end
          else if (CounterX < (`DATA_START + `DATA_PREAMBLE + `DATA_GUARDBAND + `DATA_SIZE + `DATA_SIZE + `DATA_GUARDBAND))
          begin
              dataGuardBand <= 1;
              dataChannel0 <= {1'b1, 1'b1, vSync, hSync};   
          end
          else
          begin
              tercData <= 0;
              dataGuardBand <= 0;
          end
      end
      
      if (CounterX >= (`CTL_END + `VIDEO_PREAMBLE))
      begin
          preamble <= 0;
          videoGuardBand <= 1;
      end
      else if (CounterX >= (`CTL_END))
      begin
          preamble <= 'b0001;
      end
      else
      begin
          videoGuardBand <= 0;
      end
  end

////////////////
reg [7:0] red, green, blue;

always @(negedge resetq or posedge pixclk)
if (!resetq) begin
    CounterX <= 0;
    CounterY <= 0;
    red <= 0;
    green <= 0;
    blue <= 0;
end else begin
    CounterX <= (CounterX == (`FULL_WIDTH - 1)) ? 0 : CounterX + 1;
    if(CounterX == (`FULL_WIDTH - 1)) begin
        if (CounterY == (`FULL_HEIGHT - 1)) begin
            CounterY <= 0;
        end else begin
            CounterY <= CounterY + 1;
        end
    end
    if (CounterX < `DISPLAY_WIDTH) begin
        red <= videobus[23:16];
        green <= videobus[15:8];
        blue <= videobus[7:0];
    end
end

////////////////////////////////////////////////////////////////////////
wire [9:0] TMDS_red, TMDS_green, TMDS_blue;
TMDS_encoder encode_R(.clk(pixclk), .VD(red  ), .CD(preamble[3:2]), .VDE(DrawArea), .TMDS(TMDS_red));
TMDS_encoder encode_G(.clk(pixclk), .VD(green), .CD(preamble[1:0]), .VDE(DrawArea), .TMDS(TMDS_green));
TMDS_encoder encode_B(.clk(pixclk), .VD(blue ), .CD({vSync,hSync}), .VDE(DrawArea), .TMDS(TMDS_blue));

wire [9:0] TERC4_red, TERC4_green, TERC4_blue;
TERC4_encoder encode_R4(.clk(pixclk), .data(dataChannel2), .TERC(TERC4_red));
TERC4_encoder encode_G4(.clk(pixclk), .data(dataChannel1), .TERC(TERC4_green));
TERC4_encoder encode_B4(.clk(pixclk), .data(dataChannel0), .TERC(TERC4_blue));

always @(negedge resetq or posedge pixclk)
if (!resetq) begin
    tercDataDelayed <= 0;
    videoGuardBandDelayed <= 0;
    dataGuardBandDelayed <= 0;
end else begin
    tercDataDelayed <= tercData;  // To account for delay through encoder
    videoGuardBandDelayed <= videoGuardBand;
    dataGuardBandDelayed <= dataGuardBand;
end

wire [9:0] redSource = videoGuardBandDelayed ? 10'b1011001100 : (dataGuardBandDelayed ? 10'b0100110011 : (tercDataDelayed ? TERC4_red : TMDS_red));
wire [9:0] greenSource = (dataGuardBandDelayed || videoGuardBandDelayed) ? 10'b0100110011 : (tercDataDelayed ? TERC4_green : TMDS_green);
wire [9:0] blueSource = videoGuardBandDelayed ? 10'b1011001100 : (tercDataDelayed ? TERC4_blue : TMDS_blue);
assign d = {redSource, greenSource, blueSource};

endmodule


////////////////////////////////////////////////////////////////////////
module TMDS_encoder(
    input wire clk,
    input wire [7:0] VD,  // video data (red, green or blue)
    input wire [1:0] CD,  // control data
    input wire VDE,  // video data enable, to choose between CD (when VDE=0) and VD (when VDE=1)
    output reg [9:0] TMDS
);

wire [3:0] Nb1s = VD[0] + VD[1] + VD[2] + VD[3] + VD[4] + VD[5] + VD[6] + VD[7];
wire XNOR = (Nb1s>4'd4) || (Nb1s == 4'd4 && VD[0] == 1'b0);
wire [8:0] q_m = {~XNOR, q_m[6:0] ^ VD[7:1] ^ {7{XNOR}}, VD[0]};

reg [3:0] balance_acc;

initial begin
    balance_acc=0;
end

wire [3:0] balance = q_m[0] + q_m[1] + q_m[2] + q_m[3] + q_m[4] + q_m[5] + q_m[6] + q_m[7] - 4'd4;
wire balance_sign_eq = (balance[3] == balance_acc[3]);
wire invert_q_m = (balance == 0 || balance_acc == 0) ? ~q_m[8] : balance_sign_eq;
wire [3:0] balance_acc_inc = balance - ({q_m[8] ^ ~balance_sign_eq} & ~(balance == 0 || balance_acc == 0));
wire [3:0] balance_acc_new = invert_q_m ? balance_acc - balance_acc_inc : balance_acc + balance_acc_inc;
wire [9:0] TMDS_data = {invert_q_m, q_m[8], q_m[7:0] ^ {8{invert_q_m}}};
wire [9:0] TMDS_code = CD[1] ? (CD[0] ? 10'b1010101011 : 10'b0101010100) : (CD[0] ? 10'b0010101011 : 10'b1101010100);

always @(posedge clk) TMDS <= VDE ? TMDS_data : TMDS_code;
always @(posedge clk) balance_acc <= VDE ? balance_acc_new : 4'h0;
endmodule

////////////////////////////////////////////////////////////////////////

module TERC4_encoder(
    input wire clk,
    input wire [3:0] data,
    output reg [9:0] TERC
);

always @(posedge clk)
begin
    case (data)
        4'b0000: TERC <= 10'b1010011100;
        4'b0001: TERC <= 10'b1001100011;
        4'b0010: TERC <= 10'b1011100100;
        4'b0011: TERC <= 10'b1011100010;
        4'b0100: TERC <= 10'b0101110001;
        4'b0101: TERC <= 10'b0100011110;
        4'b0110: TERC <= 10'b0110001110;
        4'b0111: TERC <= 10'b0100111100;
        4'b1000: TERC <= 10'b1011001100;
        4'b1001: TERC <= 10'b0100111001;
        4'b1010: TERC <= 10'b0110011100;
        4'b1011: TERC <= 10'b1011000110;
        4'b1100: TERC <= 10'b1010001110;
        4'b1101: TERC <= 10'b1001110001;
        4'b1110: TERC <= 10'b0101100011;
        4'b1111: TERC <= 10'b1011000011;
    endcase
end

endmodule

////////////////////////////////////////////////////////////////////////

