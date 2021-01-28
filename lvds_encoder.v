module LVDS_encoder(
  input  wire pclk,
  input  wire [29:0] d,
  input  wire pclkx2,
  input  wire pclkx10,
  input  wire serdesstrobe,

  output wire out_C_N,
  output wire out_C_P,
  output wire out_0_N,
  output wire out_0_P,
  output wire out_1_N,
  output wire out_1_P,
  output wire out_2_N,
  output wire out_2_P
  );

  wire [9:0] red, green, blue;
  assign {red, green, blue} = d;
  wire [29:0] s_data = {red[9:5], green[9:5], blue[9:5],
                        red[4:0], green[4:0], blue[4:0]};
  wire [4:0] tmds_data0, tmds_data1, tmds_data2;

  wire rstin = 0;
  wire serdes_rst = 0;

  convert_30to15_fifo pixel2x (
    .rst     (rstin),
    .clk     (pclk),
    .clkx2   (pclkx2),
    .datain  (s_data),
    .dataout ({tmds_data2, tmds_data1, tmds_data0}));

  wire [2:0] tmdsint;
  serdes_n_to_1 #(.SF(5)) oserdes0 (
             .ioclk(pclkx10),
             .serdesstrobe(serdesstrobe),
             .reset(serdes_rst),
             .gclk(pclkx2),
             .datain(tmds_data0),
             .iob_data_out(tmdsint[0])) ;

  serdes_n_to_1 #(.SF(5)) oserdes1 (
             .ioclk(pclkx10),
             .serdesstrobe(serdesstrobe),
             .reset(serdes_rst),
             .gclk(pclkx2),
             .datain(tmds_data1),
             .iob_data_out(tmdsint[1])) ;

  serdes_n_to_1 #(.SF(5)) oserdes2 (
             .ioclk(pclkx10),
             .serdesstrobe(serdesstrobe),
             .reset(serdes_rst),
             .gclk(pclkx2),
             .datain(tmds_data2),
             .iob_data_out(tmdsint[2])) ;

  wire [2:0] TMDSp, TMDSn;    // 2:red 1:grn 0:blu
  wire TMDSp_clock, TMDSn_clock;

  OBUFDS TMDS0 (.I(tmdsint[0]), .O(TMDSp[0]), .OB(TMDSn[0])) ;
  OBUFDS TMDS1 (.I(tmdsint[1]), .O(TMDSp[1]), .OB(TMDSn[1])) ;
  OBUFDS TMDS2 (.I(tmdsint[2]), .O(TMDSp[2]), .OB(TMDSn[2])) ;

  reg [4:0] tmdsclkint = 5'b00000;
  reg toggle = 1'b0;

  always @ (posedge pclkx2 or posedge serdes_rst) begin
    if (serdes_rst)
      toggle <= 1'b0;
    else
      toggle <= ~toggle;
  end

  always @ (posedge pclkx2) begin
    if (toggle)
      tmdsclkint <= 5'b11111;
    else
      tmdsclkint <= 5'b00000;
  end

  wire tmdsclk;

  serdes_n_to_1 #(
    .SF           (5))
  clkout (
    .iob_data_out (tmdsclk),
    .ioclk        (pclkx10),
    .serdesstrobe (serdesstrobe),
    .gclk         (pclkx2),
    .reset        (serdes_rst),
    .datain       (tmdsclkint));

  OBUFDS TMDS3 (.I(tmdsclk), .O(TMDSp_clock), .OB(TMDSn_clock)) ;// clock

  assign out_C_N = TMDSn_clock;
  assign out_C_P = TMDSp_clock;
  assign out_0_N = TMDSn[0];
  assign out_0_P = TMDSp[0];
  assign out_1_N = TMDSn[1];
  assign out_1_P = TMDSp[1];
  assign out_2_N = TMDSn[2];
  assign out_2_P = TMDSp[2];
endmodule

