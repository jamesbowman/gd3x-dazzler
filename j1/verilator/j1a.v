`timescale 1 ns / 1 ps

`default_nettype none
`define WIDTH 16

module j1a(input wire clk,
           input wire resetq,
           output wire uart0_wr,
           output wire uart0_rd,
           output wire [7:0] uart_w,
           input wire uart0_valid,
           input wire [7:0] uart0_data,
           input wire [26:0] mockeve_i,
           output wire [29:0] hdmi
);
  wire io_rd, io_wr;
  wire [15:0] mem_addr;
  wire mem_wr16, mem_wr8;
  wire [15:0] dout;
  wire [15:0] io_din;
  /* verilator lint_off UNUSED */
  wire [12:0] code_addr;
  wire [15:0] mem_raddr;
  /* verilator lint_on UNUSED */
  wire [15:0] din;
  wire [15:0] insn;

  reg [15:0] ram_prog[0:8191] /* verilator public_flat */;
  always @(posedge clk) begin
    // $display("pc=%x", code_addr * 2);
    insn <= ram_prog[code_addr[12:0]];
    din <= ram_prog[mem_raddr[13:1]];
    if (mem_wr16)
      ram_prog[mem_addr[13:1]] <= dout;
    if (mem_wr8)
      if (mem_addr[0] == 1'b0)
        ram_prog[mem_addr[13:1]][7:0] <= dout[7:0];
      else
        ram_prog[mem_addr[13:1]][15:8] <= dout[7:0];
  end

  j1 _j1(
    .clk(clk),
    .resetq(resetq),
    .io_rd(io_rd),
    .io_wr(io_wr),
    .mem_wr16(mem_wr16),
    .mem_wr8(mem_wr8),
    .dout(dout),
    .io_din(io_din),
    .mem_addr(mem_addr),
    .mem_raddr(mem_raddr),
    .din(din),
    .code_addr(code_addr),
    .insn(insn));

  // ######   IO SIGNALS   ####################################

  reg io_wr_, io_rd_;
  /* verilator lint_off UNUSED */
  reg [15:0] dout_;
  reg [15:0] io_addr_;
  /* verilator lint_on UNUSED */

  always @(posedge clk) begin
    {io_rd_, io_wr_, dout_} <= {io_rd, io_wr, dout};
    if (io_rd | io_wr)
      io_addr_ <= mem_addr;
  end

  // ######   UART   ##########################################

  assign uart0_wr = io_wr_ & io_addr_[12];
  assign uart0_rd = io_rd_ & io_addr_[12];
  assign uart_w = dout_[7:0];

  // always @(posedge clk) begin
  //   if (uart0_wr)
  //     $display("--- out %x %c", uart_w, uart_w);
  //   if (uart0_rd)
  //     $display("--- in %x %c", uart0_data, uart0_data);
  // end

  // ######   IO PORTS   ######################################

  /*        bit READ            WRITE
      1000  12  UART RX         UART TX
      2000  13  misc.in
  */

  assign io_din =
    (io_addr_[12] ? {8'd0, uart0_data}                                  : 16'd0) |
    (io_addr_[13] ? {12'd0, 1'b0, 1'b0, uart0_valid, 1'b1} : 16'd0);

  // HDMI interface

  reg running;
  always @(posedge clk) begin
    running <= running | mockeve_i[0];  // come to life as soon as VSYNC==1
  end

  // Generate audio samples at 48000 KHz
  reg [31:0] d = 0;
  wire [31:0] dInc = d[31] ? (48000) : (48000 - 74250000);
  wire [31:0] dN = d + dInc;
  always @(posedge clk)
  begin
    d <= dN;
  end 
  wire audio_w = ~d[31] & running;

  reg [15:0] sampleL = 16'h1111, sampleR = 16'h2222;
  always @(posedge clk)
    if (audio_w) begin
      sampleL <= sampleL + 16'h0137;
      sampleR <= sampleR + 16'h9471;
    end

  hdmi _hdmi (.clk(clk), .dd1(mockeve_i), .d(hdmi), .audio_w(audio_w), .audio({sampleR, sampleL}));
endmodule
