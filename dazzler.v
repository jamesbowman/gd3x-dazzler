`default_nettype none

`define CONFIG_SPI

module HDMI_encoder_2(
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

module bram_tdp #(
    parameter DATA = 72,
    parameter ADDR = 10
) (
    // Port A
    input    wire                a_clk,
    input    wire         [1:0]  a_wr,
    input    wire    [ADDR-1:0]  a_addr,
    input    wire    [DATA-1:0]  a_din,
    output  reg     [DATA-1:0]  a_dout,
     
    // Port B
    input    wire                b_clk,
    input    wire                b_wr,
    input    wire    [ADDR-1:0]  b_addr,
    input    wire    [DATA-1:0]  b_din,
    output  reg     [DATA-1:0]  b_dout
);
 
// Shared memory
reg [DATA-1:0] mem [(2**ADDR)-1:0];
  initial begin
    $readmemh("j1/build/base.hex", mem);
  end
 
// Port A
always @(posedge a_clk) begin
    a_dout      <= mem[a_addr];
    if(a_wr[0]) begin
        a_dout[7:0]      <= a_din[7:0];
        mem[a_addr][7:0] <= a_din[7:0];
    end
    if(a_wr[1]) begin
        a_dout[15:8]      <= a_din[15:8];
        mem[a_addr][15:8] <= a_din[15:8];
    end
end
 
// Port B
always @(posedge b_clk) begin
    b_dout      <= mem[b_addr];
    if(b_wr) begin
        b_dout      <= b_din;
        mem[b_addr] <= b_din;
    end
end
 
endmodule

module cpu(
  input  wire clk,
  input  wire resetq,
  input  wire uart_rx,
  output wire uart_tx,
  output reg  [15:0] io_a,
  output reg  [15:0] io_wd,
  input  wire [15:0] io_rd,
  output reg  io_r,
  output reg  io_w);

  wire [15:0] mem_addr, mem_raddr;
  wire mem_wr16, mem_wr8;
  wire [15:0] dout, din;

  wire [12:0] code_addr;
  wire [15:0] insn;

  wire [15:0] io_addrN, io_wdN;
  wire io_rN, io_wN;

  bram_tdp #(.DATA(16), .ADDR(13)) nram (
    .a_clk(clk),
    .a_wr({mem_wr16 | (mem_wr8 & mem_addr[0]),
           mem_wr16 | (mem_wr8 & ~mem_addr[0])}),
    .a_addr((mem_wr16 | mem_wr8) ? mem_addr[13:1] : mem_raddr[13:1]),
    .a_din(mem_wr16 ? dout : {dout[7:0], dout[7:0]}),
    .a_dout(din),

    .b_clk(clk),
    .b_wr(1'b0),
    .b_addr(code_addr[12:0]),
    .b_din(16'd0),
    .b_dout(insn));

  j1 _j1(
    .clk(clk),
    .resetq(resetq),
    .io_rd(io_rN),
    .io_wr(io_wN),
    .mem_wr16(mem_wr16),
    .mem_wr8(mem_wr8),
    .dout(dout),
    .din(din),
    .io_din(io_rd),
    .mem_addr(mem_addr),
    .mem_raddr(mem_raddr),
    .code_addr(code_addr),
    .insn(insn));

  always @(posedge clk)
    {io_w, io_r, io_a, io_wd} <= {io_wN, io_rN, mem_addr, dout};

endmodule

module integrator(
  input wire clk,
  input wire tick,
  input wire AUDIO,
  output reg [15:0] sample);

  localparam [15:0] weight = 16'd21;  // floor(32768 / 1500)

  reg [10:0] cnt;
  reg [15:0] acc;
  wire [15:0] waudio = AUDIO ? weight : -weight;

  always @(negedge clk) begin
    if (tick)
      sample <= acc;
    acc <= waudio + (tick ? 16'd0 : acc);
  end

endmodule

module wiidecoder(
  input wire [95:0] i,
  output wire [95:0] o);

  wire [5:0] lx, ly;
  wire [4:0] rt, lt, rx, ry;
  assign {rx[4:3], lx[5:0]}         = i[7:0];
  assign {rx[2:1], ly[5:0]}         = i[15:8];
  assign {rx[0], lt[4:3], ry[4:0]}  = i[23:16];
  assign {lt[2:0], rt[4:0]}         = i[31:24];

  assign o = {
    3'b000, rt,
    3'b000, lt,
    3'b000, ry,
    3'b000, rx,
    2'b00, ly,
    2'b00, lx
  };
endmodule

module gpio(
  inout wire p,
  input wire d,
  input wire o,
  output wire i);

  assign p = d ? o : 1'bz;
  assign i = p;
endmodule

module SPIengine(
  input wire clk,
  input wire start8,
  input wire start16,
  input wire [15:0] tx,
  output wire [15:0] rx,
  output wire idle,
  input wire [3:0] i,
  output wire [5:0] o,
  input wire d,
  input wire q,
  output wire [3:0] mask
  );

  reg running;
  reg [4:0] counter;
  reg [15:0] shifter;
  assign rx = shifter;

  wire [4:0] counterN = counter + (q ? 5'd4 : 5'd1);
  wire [15:0] txbe = {tx[7:0], tx[15:8]};

  wire SCK = q ? counter[2] : counter[0];

  always @(posedge clk) begin
    if (start8)
      {running, counter, shifter} <= {1'b1, 5'd16, txbe};
    else if (start16)
      {running, counter, shifter} <= {1'b1, 5'd0, txbe};
    else if (running) begin
      running <= ~(counterN == 5'd0);
      counter <= counterN;
      if (SCK)
        shifter <= (q ? {shifter[11:0], i} : {shifter[14:0], i[1]});
    end
  end
  assign idle = ~running;

  assign o = {1'b0, SCK, q ? shifter[15:12] : {3'b000, shifter[15]}};

  assign mask = q ? {4{d}} : 4'b0010;
endmodule

`define DESIGN_1_1_0

module top(
`ifdef DESIGN_1_1_0
  input  wire CLK,
  output wire X1,
`endif

  output wire CS,
  output wire SCK,
  inout  wire MOSI,   // IO0
  inout  wire MISO,   //   1
  inout  wire IO2,    //   2
  inout  wire IO3,    //   3

  output wire TMDS0_P,
  output wire TMDS0_N,
  output wire TMDS1_P,
  output wire TMDS1_N,
  output wire TMDS2_P,
  output wire TMDS2_N,
  output wire TMDS_CLK_P,
  output wire TMDS_CLK_N,

  output wire E_SCK,
  inout  wire E_MISO,
  inout  wire E_MOSI,
  inout  wire E_IO2,
  inout  wire E_IO3,
  output wire E_CS,
  output wire E_PD,

  input  wire P1,
  output wire P2,

  inout  wire P3,
  inout  wire P4,
  inout  wire P5,
  inout  wire P6,
  inout  wire P7,

  inout  wire P8,
  inout  wire P9,
  inout  wire P10,
  inout  wire P11,
  inout  wire P12,
  inout  wire P13,
  inout  wire P14,

  inout  wire P15,
  inout  wire P16,
  inout  wire P17,
  inout  wire P18,
  inout  wire P19,
  inout  wire P20,
  inout  wire P21,
  inout  wire P22,

  inout  wire P23,
  inout  wire P24,
  inout  wire P25,
  inout  wire P26,
  inout  wire P27,
  inout  wire P28,
  inout  wire P29,

  // output wire SD_2,
  // output wire SD_3,
  // output wire SD_5,
  // input  wire SD_7,

  input  wire R0, input wire R1, input wire R2, input wire R3, input wire R4, input wire R5, input wire R6, input wire R7,
  input  wire G0, input wire G1, input wire G2, input wire G3, input wire G4, input wire G5, input wire G6, input wire G7,
  input  wire B0, input wire B1, input wire B2, input wire B3, input wire B4, input wire B5, input wire B6, input wire B7,
  input  wire HSYNC,
  input  wire VSYNC,
  input  wire DE,
  input  wire PCLK,

  input wire AUDIO

  );

  wire CFG_P8;
  wire CFG_P10;
  wire CFG_P11;
  wire CFG_P13;
  wire CFG_P18;
  wire CFG_P19;
  wire CFG_P20;
  wire CFG_P22;

`ifdef DESIGN_1_1_0

  // Input CLK is 6 MHz.
  // Scale by 66/32, giving 12.375 MHz input to BT815 on X1
  // BT815 scales by 6 to give 74.25 MHz for HDMI 720p

  DCM_CLKGEN #(
  .CLKFX_MD_MAX(0.0),     // Specify maximum M/D ratio for timing anlysis
  .CLKFX_DIVIDE(32),      // Divide value - D - (1-256)
  .CLKFX_MULTIPLY(66),    // Multiply value - M - (2-256)

  .CLKIN_PERIOD(20.00),   // Input clock period specified in nS
  .STARTUP_WAIT("FALSE")  // Delay config DONE until DCM_CLKGEN LOCKED (TRUE/FALSE)
  )
  SYSCLK (
  .CLKFX(X1),           // 1-bit output: Generated clock output
  .CLKIN(CLK),            // 1-bit input: Input clock
  .FREEZEDCM(0),          // 1-bit input: Prevents frequency adjustments to input clock
  .PROGCLK(0),            // 1-bit input: Clock input for M/D reconfiguration
  .PROGDATA(0),           // 1-bit input: Serial data input for M/D reconfiguration
  .PROGEN(0),             // 1-bit input: Active high program enable
  .RST(0)                 // 1-bit input: Reset input pin
  );
`endif

  wire eveclk;

  BUFG eveclkbufg (.I(PCLK), .O(eveclk));
  wire fclk = eveclk;

  wire pclk;
  wire pllclk0, pllclk1, pllclk2;
  wire pclkx2, pclkx10, pll_lckd;
  wire clkfbout;
  PLL_BASE # (
    .CLKIN_PERIOD(13),
    .CLKFBOUT_MULT(10), //set VCO to 10x of CLKIN
    .CLKOUT0_DIVIDE(1),
    .CLKOUT1_DIVIDE(10),
    .CLKOUT2_DIVIDE(5),
    .COMPENSATION("INTERNAL")
  ) PLL_OSERDES (
    .CLKFBOUT(clkfbout),
    .CLKOUT0(pllclk0),
    .CLKOUT1(pllclk1),
    .CLKOUT2(pllclk2),
    .CLKOUT3(),
    .CLKOUT4(),
    .CLKOUT5(),
    .LOCKED(pll_lckd),
    .CLKFBIN(clkfbout),
    .CLKIN(fclk),
    .RST(1'b0)
  );

  BUFG pclkbufg (.I(pllclk1), .O(pclk));
  BUFG pclkx2bufg (.I(pllclk2), .O(pclkx2));

  wire serdesstrobe;
  BUFPLL #(.DIVIDE(5)) ioclk_buf (.PLLIN(pllclk0), .GCLK(pclkx2), .LOCKED(pll_lckd),
           .IOCLK(pclkx10), .SERDESSTROBE(serdesstrobe), .LOCK(bufpll_lock));

  wire cfgclk;
  STARTUP_SPARTAN6 _startup_startan6(
    .CFGMCLK(cfgclk));

  reg cpuclk_sel = 0;
  wire s_cpuclk;
  BUFGMUX cpuclk_mux(
    .I0(cfgclk),
    .I1(pclk),
    .S(cpuclk_sel),
    .O(s_cpuclk)
  );

  wire cpuclk;
  DCM_CLKGEN #(
  .CLKFX_MD_MAX(0.0),     // Specify maximum M/D ratio for timing anlysis
  .CLKFX_DIVIDE(2),       // Divide value - D - (1-256)
  .CLKFX_MULTIPLY(2),     // Multiply value - M - (2-256)

  .CLKIN_PERIOD(13.00),   // Input clock period specified in nS
  .STARTUP_WAIT("FALSE")  // Delay config DONE until DCM_CLKGEN LOCKED (TRUE/FALSE)
  )
  DCM_CLKGEN_inst (
  .CLKFX(cpuclk),         // 1-bit output: Generated clock output
  .CLKIN(s_cpuclk),       // 1-bit input: Input clock
  .FREEZEDCM(0),          // 1-bit input: Prevents frequency adjustments to input clock
  .PROGCLK(0),            // 1-bit input: Clock input for M/D reconfiguration
  .PROGDATA(0),           // 1-bit input: Serial data input for M/D reconfiguration
  .PROGEN(0),             // 1-bit input: Active high program enable
  .RST(0)                 // 1-bit input: Reset input pin
  );

  reg [15:0] daz_spi_command;
  reg [7:0] daz_spi_status = 8'hff;

  wire [15:0] sample;
  integrator _integrator(
    .clk(eveclk),
    .tick(audio_w),
    .AUDIO(AUDIO),
    .sample(sample));

  reg [15:0] sample2;
  always @(posedge pclk)
    sample2 <= sample;

////////////////////////////////////////////////////////////////////////

  wire uart_in = P1;
  wire uart_out;
  assign P2 = uart_out;

  wire [5:0] HSPI;

`ifdef CONFIG_SPI
  assign P8 = CFG_P8;
  assign P10 = CFG_P10;
  assign P11 = CFG_P11;
  assign P13 = CFG_P13;
  assign P18 = CFG_P18;
  assign P19 = CFG_P19;
  assign P20 = CFG_P20;
  assign P22 = CFG_P22;
`endif

`ifdef CONFIG_GPIO
  // reg [15:0] gpio0, gpio1;
  // assign {P15, P14, P13, P12, P11, P10, P9, P8, P7, P6, P5, P4, P3} = gpio0[15:3];
  // assign {P29, P28, P27, P26, P25, P24, P23, P22, P21, P20, P19, P18, P17, P16} = gpio1[13:0];
  wire [31:0] gpio_i;
  reg [31:0] gpio_d, gpio_o;

  gpio gpio_3(.p(P3), .d(gpio_d[3]), .o(gpio_o[3]), .i(gpio_i[3]));
  gpio gpio_4(.p(P4), .d(gpio_d[4]), .o(gpio_o[4]), .i(gpio_i[4]));
  gpio gpio_5(.p(P5), .d(gpio_d[5]), .o(gpio_o[5]), .i(gpio_i[5]));
  gpio gpio_6(.p(P6), .d(gpio_d[6]), .o(gpio_o[6]), .i(gpio_i[6]));
  gpio gpio_7(.p(P7), .d(gpio_d[7]), .o(gpio_o[7]), .i(gpio_i[7]));
  gpio gpio_8(.p(P8), .d(gpio_d[8]), .o(gpio_o[8]), .i(gpio_i[8]));
  gpio gpio_9(.p(P9), .d(gpio_d[9]), .o(gpio_o[9]), .i(gpio_i[9]));
  gpio gpio_10(.p(P10), .d(gpio_d[10]), .o(gpio_o[10]), .i(gpio_i[10]));
  gpio gpio_11(.p(P11), .d(gpio_d[11]), .o(gpio_o[11]), .i(gpio_i[11]));
  gpio gpio_12(.p(P12), .d(gpio_d[12]), .o(gpio_o[12]), .i(gpio_i[12]));
  gpio gpio_13(.p(P13), .d(gpio_d[13]), .o(gpio_o[13]), .i(gpio_i[13]));
  gpio gpio_14(.p(P14), .d(gpio_d[14]), .o(gpio_o[14]), .i(gpio_i[14]));
  gpio gpio_15(.p(P15), .d(gpio_d[15]), .o(gpio_o[15]), .i(gpio_i[15]));
  gpio gpio_16(.p(P16), .d(gpio_d[16]), .o(gpio_o[16]), .i(gpio_i[16]));
  gpio gpio_17(.p(P17), .d(gpio_d[17]), .o(gpio_o[17]), .i(gpio_i[17]));
  gpio gpio_18(.p(P18), .d(gpio_d[18]), .o(gpio_o[18]), .i(gpio_i[18]));
  gpio gpio_19(.p(P19), .d(gpio_d[19]), .o(gpio_o[19]), .i(gpio_i[19]));
  gpio gpio_20(.p(P20), .d(gpio_d[20]), .o(gpio_o[20]), .i(gpio_i[20]));
  gpio gpio_21(.p(P21), .d(gpio_d[21]), .o(gpio_o[21]), .i(gpio_i[21]));
  gpio gpio_22(.p(P22), .d(gpio_d[22]), .o(gpio_o[22]), .i(gpio_i[22]));
  gpio gpio_23(.p(P23), .d(gpio_d[23]), .o(gpio_o[23]), .i(gpio_i[23]));
  gpio gpio_24(.p(P24), .d(gpio_d[24]), .o(gpio_o[24]), .i(gpio_i[24]));
  gpio gpio_25(.p(P25), .d(gpio_d[25]), .o(gpio_o[25]), .i(gpio_i[25]));
  gpio gpio_26(.p(P26), .d(gpio_d[26]), .o(gpio_o[26]), .i(gpio_i[26]));
  gpio gpio_27(.p(P27), .d(gpio_d[27]), .o(gpio_o[27]), .i(gpio_i[27]));
  gpio gpio_28(.p(P28), .d(gpio_d[28]), .o(gpio_o[28]), .i(gpio_i[28]));
  gpio gpio_29(.p(P29), .d(gpio_d[29]), .o(gpio_o[29]), .i(gpio_i[29]));
`endif

  wire [15:0] debug0 = {
    P15,
    P14,
    P13,
    P12,
    P11,
    P10,
    P9,
    P8,
    P7,
    P6,
    P5,

    P4,
    P3,
    3'b000
    };
  wire [15:0] debug1 = {
    1'b0,
    AUDIO,
    P29,
    P28,

    P27,
    P26,
    P25,
    P24,

    P23,
    P22,
    P21,
    P20,

    P19,
    P18,
    P17,
    P16
    };

  wire bufpll_lock;
  wire [15:0] debug2 = {
    10'd0,

    pll_lckd,
    bufpll_lock,

    VSYNC,
    HSYNC,
    DE,
    PCLK
  };
  reg [15:0] probe;

  reg [15:0] brktimer = 0;
  wire softresetq = ~(&brktimer);
  always @(posedge cpuclk)
    if (uart_in)
      brktimer <= 0;
    else if (softresetq)
      brktimer <= brktimer + 16'd1;

  wire resetq = softresetq;
  wire [15:0] io_a, io_wd, io_rd;
  wire io_r, io_w;
  cpu _cpu (
    .clk(cpuclk),
    .resetq(resetq),
    .io_a(io_a),
    .io_wd(io_wd),
    .io_rd(io_rd),
    .io_r(io_r),
    .io_w(io_w)
  );

  wire uart0_wr = io_w & io_a[12];
  wire uart0_rd = io_r & io_a[12];

  wire uart0_valid, uart0_busy;
  wire [7:0] uart0_data;
  reg [31:0] clkfreq = cpuclk_sel ? 32'd72000000 : 32'd50000000;
  reg [31:0] uart0_baud = 32'd1000000;

  buart _uart0 (
     .clk(cpuclk),
     .resetq(resetq),
     .clkfreq(clkfreq),
     .baud(uart0_baud),
     .rx(uart_in),
     .tx(uart_out),
     .rd(uart0_rd),
     .wr(uart0_wr),
     .valid(uart0_valid),
     .busy(uart0_busy),
     .tx_data(io_wd[7:0]),
     .rx_data(uart0_data));

  wire uart1_valid, uart1_rd;
  wire [7:0] uart1_data;
  reg [31:0] uart1_baud = 32'd115200;

  assign uart1_rd = io_r & io_a[11:0] == 12'h01a;

  rxuart  _uart1 (
     .clk(cpuclk),
     .resetq(resetq),
     .baud(uart1_baud),
     .clkfreq(clkfreq),
     .uart_rx(P23),
     .rd(uart1_rd),
     .valid(uart1_valid),
     .data(uart1_data));

  reg [15:0] ticks;
  always @(posedge cpuclk)
    ticks <= ticks + 1;

  reg [2:0] ICAP_ctl;
  wire ICAP_busy;
  reg [15:0] ICAP_i;
  wire [15:0] ICAP_o;
  ICAP_SPARTAN6 icap (
    .CLK(ICAP_ctl[0]),
    .CE( ICAP_ctl[1]),
    .WRITE(ICAP_ctl[2]),
    .I(ICAP_i),
    .O(ICAP_o),
    .BUSY(ICAP_busy));

  reg dna_read;
  reg dna_shift;
  reg dna_clk;
  wire dna_dout;
  DNA_PORT dna(
    .DOUT(dna_dout),
    .DIN(0),
    .READ(dna_read),
    .SHIFT(dna_shift),
    .CLK(dna_clk));

  wire [5:0] i2c_i = {P8, P9, P10, P11, P12, P13};
  reg [5:0] i2c_o = 6'b111111;
  assign CFG_P8   = i2c_o[5] ? 1'bz : 1'b0;
  assign CFG_P10  = i2c_o[3] ? 1'bz : 1'b0;
  assign CFG_P11  = i2c_o[2] ? 1'bz : 1'b0;
  assign CFG_P13  = i2c_o[0] ? 1'bz : 1'b0;

  wire [15:0] cspie_rx;
  wire cspie_idle;
  wire [5:0] CSPIe;

  SPIengine Ceng (
    .clk(cpuclk),
    .start8(io_w & (io_a[11:0] == 12'h101)),
    .start16(io_w & (io_a[11:0] == 12'h102)),
    .tx(io_wd),
    .rx(cspie_rx),
    .i(CSPI_i),
    .o(CSPIe),
    .d(CSPI_dir),
    .q(CSPI_quad),
    .mask(CSPI_mask),
    .idle(cspie_idle));

  wire [15:0] dspie_rx;
  wire dspie_idle;
  wire [5:0] DSPIe;
  SPIengine Deng (
    .clk(cpuclk),
    .start8(io_w & (io_a[11:0] == 12'h111)),
    .start16(io_w & (io_a[11:0] == 12'h112)),
    .tx(io_wd),
    .rx(dspie_rx),
    .i(DSPI_i),
    .o(DSPIe),
    .d(DSPI_dir),
    .q(DSPI_quad),
    .mask(DSPI_mask),
    .idle(dspie_idle));

  wire [15:0] espie_rx;
  wire espie_idle;
  wire [5:0] ESPIe;
  SPIengine Eeng (
    .clk(cpuclk),
    .start8(io_w & (io_a[11:0] == 12'h121)),
    .start16(io_w & (io_a[11:0] == 12'h122)),
    .tx(io_wd),
    .rx(espie_rx),
    .i(ESPI_i),
    .o(ESPIe),
    .d(ESPI_dir),
    .q(ESPI_quad),
    .mask(ESPI_mask),
    .idle(espie_idle));

  wire DSPI_MISO, ESPI_MISO;
  reg [5:0] CSPI0, DSPI0, ESPI0;

  reg dd_oa_reset;
  reg [31:0] dd_o, dd_a;

  // ------------------------------------------------------------------------

  wire clk6502;
  wire [7:0] dvgd;
  reg [12:0] dvga;
  reg m6502_reset = 1'b1, m6502_run = 1'b0;
  reg m6502_clk = 1'b1;
  wire [15:0] m6502_debug;
  wire clkout_i;

`ifdef KIPPER
  DCM_CLKGEN #(
  .CLKFX_MD_MAX(0.0),     // Specify maximum M/D ratio for timing anlysis
  .CLKFX_MULTIPLY(4),    // Multiply value - M - (2-256)
  .CLKFX_DIVIDE(1),      // Divide value - D - (1-256)

  .CLKIN_PERIOD(166.00),   // Input clock period specified in nS
  .STARTUP_WAIT("FALSE")  // Delay config DONE until DCM_CLKGEN LOCKED (TRUE/FALSE)
  )
  CLK6502 (
  .CLKFX(clkout_i),        // 1-bit output: Generated clock output
  .CLKIN(CLK),            // 1-bit input: Input clock
  .FREEZEDCM(0),          // 1-bit input: Prevents frequency adjustments to input clock
  .PROGCLK(0),            // 1-bit input: Clock input for M/D reconfiguration
  .PROGDATA(0),           // 1-bit input: Serial data input for M/D reconfiguration
  .PROGEN(0),             // 1-bit input: Active high program enable
  .RST(0)                 // 1-bit input: Reset input pin
  );

  // BUFG BUFG_6502 ( .I(clkout_i), .O(clk6502));
`endif
  wire dvg_go;

  reg [15:0] asteroids_switches;

  asteroids _asteroids (
    .fastclk(cpuclk),
    .reset(m6502_reset),
    .run(m6502_run),
    .in1in0(asteroids_switches),
    .GODVG(dvg_go),
    .dvgclk(cpuclk),
    .dvga(dvga),
    .dvgd(dvgd),
    .debug(m6502_debug)
  );

  reg dvg_go_flag = 0;
  always @(posedge cpuclk) begin
    if (dvg_go)
      dvg_go_flag <= ~dvg_go_flag;
  end

  // ------------------------------------------------------------------------

  // 5    4    3    2    1    0
  // CS   SCK  IO3  IO2  MISO MOSI

  assign io_rd =
    ((io_a[11:0] == 12'h002) ? {13'd0, i2c_i[2:0]} : 16'd0) | 
    ((io_a[11:0] == 12'h003) ? {13'd0, i2c_i[5:3]} : 16'd0) | 
    ((io_a[11:0] == 12'h012) ? {12'd0, ICAP_busy, ICAP_ctl} : 16'd0) | 
    ((io_a[11:0] == 12'h013) ? ICAP_o : 16'd0) | 
    ((io_a[11:0] == 12'h014) ? sysctl : 16'd0) | 
    ((io_a[11:0] == 12'h015) ? ticks : 16'd0) | 
    ((io_a[11:0] == 12'h016) ? debug0 : 16'd0) | 
    ((io_a[11:0] == 12'h017) ? debug1 : 16'd0) | 
    ((io_a[11:0] == 12'h018) ? debug2 : 16'd0) | 
    ((io_a[11:0] == 12'h019) ? {15'b0, uart1_valid} : 16'd0) | 
    ((io_a[11:0] == 12'h01a) ? {8'b0, uart1_data} : 16'd0) | 

    ((io_a[11:0] == 12'h100) ? {12'd0, CSPI_i} : 16'd0) |                         // CSPI
    ((io_a[11:0] == 12'h101) ? cspie_rx : 16'd0) | 
    ((io_a[11:0] == 12'h102) ? cspie_rx : 16'd0) | 
    ((io_a[11:0] == 12'h103) ? {15'd0, cspie_idle} : 16'd0) | 

    ((io_a[11:0] == 12'h110) ? {12'd0, IO3, IO2, DSPI_MISO, MOSI} : 16'd0) |      // DSPI
    ((io_a[11:0] == 12'h111) ? dspie_rx : 16'd0) | 
    ((io_a[11:0] == 12'h112) ? dspie_rx : 16'd0) | 
    ((io_a[11:0] == 12'h113) ? {15'd0, dspie_idle} : 16'd0) | 

    ((io_a[11:0] == 12'h120) ? {14'd0, ESPI_MISO, P19} : 16'd0) |                 // ESPI
    ((io_a[11:0] == 12'h121) ? espie_rx : 16'd0) | 
    ((io_a[11:0] == 12'h122) ? espie_rx : 16'd0) | 
    ((io_a[11:0] == 12'h123) ? {15'd0, espie_idle} : 16'd0) | 

    ((io_a[11:0] == 12'h200) ? dd_o[15:0] : 16'd0) |                              // video bus debug
    ((io_a[11:0] == 12'h201) ? dd_o[31:16] : 16'd0) |                             // video bus debug
    ((io_a[11:0] == 12'h202) ? dd_a[15:0] : 16'd0) |                              // video bus debug
    ((io_a[11:0] == 12'h203) ? dd_a[31:16] : 16'd0) |                             // video bus debug

    ((io_a[11:0] == 12'h204) ? {15'd0, dna_dout} : 16'd0) |                       // DNA_PORT serial out

    ((io_a[11:0] == 12'h300) ? {8'd0, dvgd} : 16'd0) |                            // 
    ((io_a[11:0] == 12'h301) ? m6502_debug : 16'd0) |                             // 
    ((io_a[11:0] == 12'h302) ? {15'd0, dvg_go_flag} : 16'd0) |                    // 

    ((io_a[11:0] == 12'h600) ? {8'd0, daz_spi_status} : 16'd0) |                  // 
    ((io_a[11:0] == 12'h601) ? daz_spi_command : 16'd0) |                         // 
    ((io_a[11:0] == 12'h602) ? {15'd0, daz_spi_mailbox} : 16'd0) |                         // 

    (io_a[12] ? {8'd0, uart0_data} : 16'd0) | 
    (io_a[13] ? {11'd0, 1'b0, 1'b0, 1'b0, uart0_valid, !uart0_busy} : 16'd0);

  reg[2:0] MUX0;

  reg [47:0] WII1 = 48'h123456789abc;
  reg [47:0] WII2 = 48'h123456789abc;

  reg [15:0] sysctl;

  // 5    4    3    2    1    0
  // CS   SCK  IO3  IO2  MISO MOSI

  always @(posedge cpuclk) begin
    if (io_w & (io_a[11:0] == 12'h002))
      i2c_o[2:0] <= io_wd[2:0];
    if (io_w & (io_a[11:0] == 12'h003))
      i2c_o[5:3] <= io_wd[2:0];

    if (io_w & (io_a[11:0] == 12'h004))
      WII1[15:0] <= io_wd;
    if (io_w & (io_a[11:0] == 12'h005))
      WII1[31:16] <= io_wd;
    if (io_w & (io_a[11:0] == 12'h006))
      WII1[47:32] <= io_wd;
    if (io_w & (io_a[11:0] == 12'h007))
      WII2[15:0] <= io_wd;
    if (io_w & (io_a[11:0] == 12'h008))
      WII2[31:16] <= io_wd;
    if (io_w & (io_a[11:0] == 12'h009))
      WII2[47:32] <= io_wd;

    if (io_w & (io_a[11:0] == 12'h011))
      MUX0 <= io_wd[2:0];
    if (io_w & (io_a[11:0] == 12'h012))
      ICAP_ctl <= io_wd[2:0];
    if (io_w & (io_a[11:0] == 12'h013))
      ICAP_i <= io_wd;
    if (io_w & (io_a[11:0] == 12'h014))
      sysctl <= io_wd;
    if (io_w & (io_a[11:0] == 12'h018))
      probe <= io_wd;

    if (io_w & (io_a[11:0] == 12'h080))
      cpuclk_sel <= io_wd[0];

    if (io_w & (io_a[11:0] == 12'h100))
      CSPI0 <= io_wd[5:0];
    if (io_w & (io_a[11:0] == 12'h104))
      CSPI_dir <= io_wd[0];
    if (io_w & (io_a[11:0] == 12'h105))
      CSPI_quad <= io_wd[0];

    if (io_w & (io_a[11:0] == 12'h110))
      DSPI0 <= io_wd[5:0];
    if (io_w & (io_a[11:0] == 12'h114))
      DSPI_dir <= io_wd[0];
    if (io_w & (io_a[11:0] == 12'h115))
      DSPI_quad <= io_wd[0];

    if (io_w & (io_a[11:0] == 12'h120))
      ESPI0 <= io_wd[5:0];
    if (io_w & (io_a[11:0] == 12'h124))
      ESPI_dir <= io_wd[0];
    if (io_w & (io_a[11:0] == 12'h125))
      ESPI_quad <= io_wd[0];

    if (io_w & (io_a[11:0] == 12'h200))
      dd_oa_reset <= io_wd[0];

    if (io_w & (io_a[11:0] == 12'h204))
      {dna_read, dna_shift, dna_clk} <= io_wd[2:0];

    if (io_w & (io_a[11:0] == 12'h300))
      dvga <= io_wd[12:0];
    if (io_w & (io_a[11:0] == 12'h301))
      {m6502_run, m6502_reset} <= io_wd[1:0];

`ifdef CONFIG_GPIO
    if (io_w & (io_a[11:5] == {4'h4, 3'b000})) begin
      gpio_d[io_a[4:0]] <= io_wd[1];
      gpio_o[io_a[4:0]] <= io_wd[0];
    end
`endif

    if (io_w & (io_a[11:0] == 12'h500))
      asteroids_switches <= io_wd;

  end

  wire [47:0] WII1e, WII2e;
  wiidecoder _wiidecoder1(.i(WII1), .o(WII1e));
  wiidecoder _wiidecoder2(.i(WII2), .o(WII2e));

////////////////////////////////////////////////////////////////////////

  wire [2:0] TMDSp, TMDSn;    // 2:red 1:grn 0:blu
  wire TMDSp_clock, TMDSn_clock;

  reg [26:0] dd0, dd1;

  // wire ror = |({R7, R6, R5, R4, R3, R2, R1, R0});

  always @(negedge eveclk)
    dd0 <= {
           R7, R6, R5, R4, R3, R2, R1, R0,
           G7, G6, G5, G4, G3, G2, G1, G0,
           B7, B6, B5, B4, B3, B2, B1, B0,
           DE, HSYNC, VSYNC };
  always @(posedge pclk)
    dd1 <= dd0;

  reg [15:0] sample3;
  always @(posedge pclk)
    sample3 <= (sample3 + 1) & 16'h00ff;

  // Generate audio samples at 48000 KHz
  reg [31:0] d = 0;
  wire [31:0] dInc = d[31] ? (48000) : (48000 - 74250000);
  wire [31:0] dN = d + dInc;
  always @(posedge pclk)
  begin
    d <= dN;
  end 
  wire audio_w = ~d[31];

  reg [15:0] sampleL = 16'h1111, sampleR = 16'h2222;
  always @(posedge pclk)
    if (audio_w) begin
      sampleL <= sampleL + 16'haa;
      sampleR <= sampleR + 16'hbb;
    end

  reg [6:0] th;
  reg [15:0] sa;
  always @(posedge pclk)
    if (audio_w)
      th <= th + 7'd1;
  always @*
    case (th)
7'h00: sa = 16'h0000;
7'h01: sa = 16'h0647;
7'h02: sa = 16'h0c8b;
7'h03: sa = 16'h12c7;
7'h04: sa = 16'h18f8;
7'h05: sa = 16'h1f19;
7'h06: sa = 16'h2527;
7'h07: sa = 16'h2b1e;
7'h08: sa = 16'h30fb;
7'h09: sa = 16'h36b9;
7'h0a: sa = 16'h3c56;
7'h0b: sa = 16'h41cd;
7'h0c: sa = 16'h471c;
7'h0d: sa = 16'h4c3f;
7'h0e: sa = 16'h5133;
7'h0f: sa = 16'h55f4;
7'h10: sa = 16'h5a81;
7'h11: sa = 16'h5ed6;
7'h12: sa = 16'h62f1;
7'h13: sa = 16'h66ce;
7'h14: sa = 16'h6a6c;
7'h15: sa = 16'h6dc9;
7'h16: sa = 16'h70e1;
7'h17: sa = 16'h73b5;
7'h18: sa = 16'h7640;
7'h19: sa = 16'h7883;
7'h1a: sa = 16'h7a7c;
7'h1b: sa = 16'h7c29;
7'h1c: sa = 16'h7d89;
7'h1d: sa = 16'h7e9c;
7'h1e: sa = 16'h7f61;
7'h1f: sa = 16'h7fd7;
7'h20: sa = 16'h7fff;
7'h21: sa = 16'h7fd7;
7'h22: sa = 16'h7f61;
7'h23: sa = 16'h7e9c;
7'h24: sa = 16'h7d89;
7'h25: sa = 16'h7c29;
7'h26: sa = 16'h7a7c;
7'h27: sa = 16'h7883;
7'h28: sa = 16'h7640;
7'h29: sa = 16'h73b5;
7'h2a: sa = 16'h70e1;
7'h2b: sa = 16'h6dc9;
7'h2c: sa = 16'h6a6c;
7'h2d: sa = 16'h66ce;
7'h2e: sa = 16'h62f1;
7'h2f: sa = 16'h5ed6;
7'h30: sa = 16'h5a81;
7'h31: sa = 16'h55f4;
7'h32: sa = 16'h5133;
7'h33: sa = 16'h4c3f;
7'h34: sa = 16'h471c;
7'h35: sa = 16'h41cd;
7'h36: sa = 16'h3c56;
7'h37: sa = 16'h36b9;
7'h38: sa = 16'h30fb;
7'h39: sa = 16'h2b1e;
7'h3a: sa = 16'h2527;
7'h3b: sa = 16'h1f19;
7'h3c: sa = 16'h18f8;
7'h3d: sa = 16'h12c7;
7'h3e: sa = 16'h0c8b;
7'h3f: sa = 16'h0647;
7'h40: sa = 16'h0000;
7'h41: sa = 16'hf9b9;
7'h42: sa = 16'hf375;
7'h43: sa = 16'hed39;
7'h44: sa = 16'he708;
7'h45: sa = 16'he0e7;
7'h46: sa = 16'hdad9;
7'h47: sa = 16'hd4e2;
7'h48: sa = 16'hcf05;
7'h49: sa = 16'hc947;
7'h4a: sa = 16'hc3aa;
7'h4b: sa = 16'hbe33;
7'h4c: sa = 16'hb8e4;
7'h4d: sa = 16'hb3c1;
7'h4e: sa = 16'haecd;
7'h4f: sa = 16'haa0c;
7'h50: sa = 16'ha57f;
7'h51: sa = 16'ha12a;
7'h52: sa = 16'h9d0f;
7'h53: sa = 16'h9932;
7'h54: sa = 16'h9594;
7'h55: sa = 16'h9237;
7'h56: sa = 16'h8f1f;
7'h57: sa = 16'h8c4b;
7'h58: sa = 16'h89c0;
7'h59: sa = 16'h877d;
7'h5a: sa = 16'h8584;
7'h5b: sa = 16'h83d7;
7'h5c: sa = 16'h8277;
7'h5d: sa = 16'h8164;
7'h5e: sa = 16'h809f;
7'h5f: sa = 16'h8029;
7'h60: sa = 16'h8001;
7'h61: sa = 16'h8029;
7'h62: sa = 16'h809f;
7'h63: sa = 16'h8164;
7'h64: sa = 16'h8277;
7'h65: sa = 16'h83d7;
7'h66: sa = 16'h8584;
7'h67: sa = 16'h877d;
7'h68: sa = 16'h89c0;
7'h69: sa = 16'h8c4b;
7'h6a: sa = 16'h8f1f;
7'h6b: sa = 16'h9237;
7'h6c: sa = 16'h9594;
7'h6d: sa = 16'h9932;
7'h6e: sa = 16'h9d0f;
7'h6f: sa = 16'ha12a;
7'h70: sa = 16'ha57f;
7'h71: sa = 16'haa0c;
7'h72: sa = 16'haecd;
7'h73: sa = 16'hb3c1;
7'h74: sa = 16'hb8e4;
7'h75: sa = 16'hbe33;
7'h76: sa = 16'hc3aa;
7'h77: sa = 16'hc947;
7'h78: sa = 16'hcf05;
7'h79: sa = 16'hd4e2;
7'h7a: sa = 16'hdad9;
7'h7b: sa = 16'he0e7;
7'h7c: sa = 16'he708;
7'h7d: sa = 16'hed39;
7'h7e: sa = 16'hf375;
7'h7f: sa = 16'hf9b9;
    endcase

  always @(posedge pclk) begin
    if (dd_oa_reset) begin
      dd_o <= 32'd00000000;
      dd_a <= 32'hffffffff;
    end else begin
      dd_o <= dd_o | dd1;
      dd_a <= dd_a & dd1;
    end
  end

  wire [29:0] d0;
  hdmi hdmi_ (.clk(pclk), .dd1(dd1), .d(d0), .audio_w(audio_w), .audio({sample, sample}));
`ifdef DEBUG_LVDS
    assign {
      TMDS_CLK_N,
      TMDS_CLK_P,
      TMDS0_N,
      TMDS0_P,
      TMDS1_N,
      TMDS1_P,
      TMDS2_N,
      TMDS2_P} = probe[7:0];
`else
  HDMI_encoder_2 e2(
    .pclk(pclk),
    .d(d0),
    .pclkx2(pclkx2),
    .pclkx10(pclkx10),
    .serdesstrobe(serdesstrobe),

    .out_C_N(TMDS_CLK_N),
    .out_C_P(TMDS_CLK_P),
    .out_0_N(TMDS0_N),
    .out_0_P(TMDS0_P),
    .out_1_N(TMDS1_N),
    .out_1_P(TMDS1_P),
    .out_2_N(TMDS2_N),
    .out_2_P(TMDS2_P)
    );
`endif

  // 5    4    3    2    1    0
  // CS   SCK  IO3  IO2  MISO MOSI

  wire dummy0;

  assign HSPI = {    P25, P29, 3'b000,        P28};

  wire [5:0] eveM   = MUX0[0] ? HSPI : (CSPI0 | CSPIe);
  reg CSPI_dir, CSPI_quad;
  wire [3:0] CSPI_mask;
  assign {E_CS, E_SCK} = eveM[5:4];
  assign E_IO3  = CSPI_mask[3] ? 1'bz : eveM[3];
  assign E_IO2  = CSPI_mask[2] ? 1'bz : eveM[2];
  assign E_MISO = CSPI_mask[1] ? 1'bz : eveM[1];
  assign E_MOSI = CSPI_mask[0] ? 1'bz : eveM[0];
  wire [3:0] CSPI_i = {E_IO3, E_IO2, E_MISO, E_MOSI};

  wire [5:0] flashM = MUX0[1] ? HSPI : (DSPI0 | DSPIe);
  reg DSPI_dir, DSPI_quad;
  wire [3:0] DSPI_mask;
  assign {CS, SCK} = flashM[5:4];
  assign IO3  = DSPI_mask[3] ? 1'bz : flashM[3];
  assign IO2  = DSPI_mask[2] ? 1'bz : flashM[2];
  assign MISO = DSPI_mask[1] ? 1'bz : flashM[1];
  assign MOSI = DSPI_mask[0] ? 1'bz : flashM[0];
  assign DSPI_MISO = MISO;
  wire [3:0] DSPI_i = {IO3, IO2, MISO, MOSI};

  reg ESPI_dir, ESPI_quad;
  wire [3:0] ESPI_mask;
  assign ESPI_MISO = P17;

  assign CFG_P20 = MUX0[2] ? P26     : (ESPI0[5] | ESPIe[5]);   // CS
  assign CFG_P18 = MUX0[2] ? HSPI[4] : (ESPI0[4] | ESPIe[4]);   // SCK
  assign CFG_P19 = MUX0[2] ? HSPI[0] : (ESPI0[0] | ESPIe[0]);   // MOSI
  wire [3:0] ESPI_i = {2'b00, P17, 1'b0};

  assign E_PD = sysctl[0];

  reg hMISO;
  wire chMISO;
  always @*
    if (P25 == 1'b0)
      case (MUX0[1:0])
      2'b01: hMISO <= E_MISO;
      2'b10: hMISO <= MISO;
      default: hMISO <= 1'bz;
      endcase
    else if (P26 == 1'b0)
      hMISO <= P17;
    else if (P27 == 1'b0)
      hMISO <= chMISO;

  assign CFG_P22 = hMISO;

  wire SCKclock;
  BUFG _sck (.I(HSPI[4]), .O(SCKclock));
  reg [207:0] sup_sr;
  reg [7:0] sup_ix;

  reg daz_spi_mailbox;
  reg daz_spi_mailbox_;

  always @(posedge P27 or posedge SCKclock)
    if (P27) begin
      sup_sr <= {WII2e, WII2, WII1e, WII1, daz_spi_status, 8'hda};
      sup_ix <= 0;
    end else begin
      if (sup_ix < 8'd16)
        daz_spi_command <= {daz_spi_command[14:0], P28};
      if (sup_ix == 8'd15)
        daz_spi_mailbox <= ~daz_spi_mailbox;
      sup_ix <= sup_ix + 8'd1;
    end

  reg [3:0] mbox;
  always @(posedge cpuclk)
    mbox <= {daz_spi_mailbox, mbox[3:1]};

  always @(posedge cpuclk) begin
    if (mbox[0] != daz_spi_mailbox_) begin
      daz_spi_status <= 8'hff;
    end
    daz_spi_mailbox_ <= mbox[0];

    if (io_w & (io_a[11:0] == 12'h600))
      daz_spi_status <= io_wd[7:0];
  end

  assign chMISO = sup_sr[{sup_ix[7:3], ~sup_ix[2:0]}];

  // assign SD_2 = P8;
  // assign SD_3 = P6;
  // assign SD_5 = P4;

endmodule
