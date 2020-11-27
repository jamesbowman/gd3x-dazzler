`default_nettype none
`define WIDTH 16

module j1(
  input wire clk,
  input wire resetq,

  output wire io_rd,
  output wire io_wr,
  output wire [15:0] mem_addr,
  output wire mem_wr16,
  output wire mem_wr8,
  output wire [`WIDTH-1:0] dout,

  output wire [15:0] mem_raddr,
  /* verilator lint_off UNUSED */
  input  wire [`WIDTH-1:0] din,
  /* verilator lint_on UNUSED */

  input  wire [`WIDTH-1:0] io_din,

  output wire [12:0] code_addr,
  input  wire [15:0] insn);

  reg [3:0] dsp, dspN;          // data stack pointer
  reg [`WIDTH-1:0] st0, st0N;   // top of data stack
  reg dstkW;                    // data stack write

  reg [12:0] pc /* verilator public_flat */, pcN;           // program counter
  wire [12:0] pc_plus_1 = pc + 13'd1;
  reg rstkW;                    // return stack write
  wire [`WIDTH-1:0] rstkD;      // return stack write value
  reg reboot = 1;

  assign mem_addr = st0[15:0];
  assign mem_raddr = st0N[15:0];
  assign code_addr = pcN;

  // The D and R stacks
  wire [`WIDTH-1:0] st1, rst0;
  reg [1:0] dspI, rspI;
  // 4 ok
  // 8 hangs
  // 15
  stack2 #(.DEPTH(32)) dstack(.clk(clk), .rd(st1),  .we(dstkW), .wd(st0),   .delta(dspI));
  stack2 #(.DEPTH(32)) rstack(.clk(clk), .rd(rst0), .we(rstkW), .wd(rstkD), .delta(rspI));

  wire [16:0] minus = {1'b1, ~st0} + st1 + 1;
  wire signedless = st0[15] ^ st1[15] ? st1[15] : minus[16];

  wire [15:0] flip0 = st0[0] ? {st1[14],st1[15],
                                st1[12],st1[13],
                                st1[10],st1[11],
                                st1[8],st1[9],
                                st1[6],st1[7],
                                st1[4],st1[5],
                                st1[2],st1[3],
                                st1[0],st1[1]} : st1;
  wire [15:0] flip1 = st0[1] ? {flip0[13:12],flip0[15:14],
                                flip0[9:8],flip0[11:10],
                                flip0[5:4],flip0[7:6],
                                flip0[1:0],flip0[3:2]}: flip0;
  wire [15:0] flip2 = st0[2] ? {flip1[11:8],flip1[15:12],
                                flip1[3:0],flip1[7:4]}: flip1;
  wire [15:0] flip  = st0[3] ? {flip2[7:0],flip2[15:8]} : flip2;

  wire [31:0] product = {16'd0, st0} * {16'd0, st1};

  always @*
  begin
    // Compute the new value of st0
    casez (insn[15:8])
      8'b1??_?????: st0N = { {(`WIDTH - 15){1'b0}}, insn[14:0] };    // literal
      8'b000_?????: st0N = st0;                     // jump
      8'b010_?????: st0N = st0;                     // call
      8'b001_?????: st0N = st1;                     // conditional jump
      8'b011_00000: st0N = st0;                     // ALU operations...
      8'b011_00001: st0N = st1;
      8'b011_00010: st0N = st0 + st1;
      8'b011_00011: st0N = st0 & st1;
      8'b011_00100: st0N = st0 | st1;
      8'b011_00101: st0N = st0 ^ st1;
      8'b011_00110: st0N = ~st0;

      8'b011_00111: st0N = {`WIDTH{(minus == 0)}};                //  =
      8'b011_01000: st0N = {`WIDTH{(signedless)}};                //  <

      8'b011_01001: st0N = {st0[`WIDTH - 1], st0[`WIDTH - 1:1]};
      8'b011_01010: st0N = {st0[`WIDTH - 2:0], 1'b0};
      8'b011_01011: st0N = rst0;
      8'b011_01100: st0N = minus[15:0];
      8'b011_01101: st0N = io_din;
      8'b011_01110: st0N = {{(`WIDTH - 4){1'b0}}, dsp};
      8'b011_01111: st0N = {`WIDTH{(minus[16])}};                 // u<
      8'b011_10000: st0N = din;                                   // mem read
      8'b011_10001: st0N = {8'd0, st0[0] ? din[15:8] : din[7:0]}; // mem byte read
      8'b011_10010: st0N = st1 >> st0[3:0];
      8'b011_10011: st0N = st1 << st0[3:0];
      8'b011_10100: st0N = flip;
      8'b011_10101: st0N = product[15:0];
      8'b011_10110: st0N = product[31:16];
      default: st0N = {`WIDTH{1'bx}};
    endcase
  end

  wire func_T_N =   (insn[6:4] == 1);
  wire func_T_R =   (insn[6:4] == 2);
  wire func_write = (insn[6:4] == 3);
  wire func_iow =   (insn[6:4] == 4);
  wire func_ior =   (insn[6:4] == 5);
  wire func_wr_8 =  (insn[6:4] == 6);

  wire is_alu = !pc[12] & (insn[15:13] == 3'b011);
  assign mem_wr16 = !reboot & is_alu & func_write;
  assign mem_wr8 = !reboot & is_alu & func_wr_8;
  assign dout = st1;
  assign io_wr = !reboot & is_alu & func_iow;
  assign io_rd = !reboot & is_alu & func_ior;

  assign rstkD = (insn[13] == 1'b0) ? {{(`WIDTH - 14){1'b0}}, pc_plus_1, 1'b0} : st0;

  always @*
  begin
    casez (insn[15:13])
    3'b1??:   {dstkW, dspI} = {1'b1,      2'b01};
    3'b001:   {dstkW, dspI} = {1'b0,      2'b11};
    3'b011:   {dstkW, dspI} = {func_T_N,  {insn[1:0]}};
    default:    {dstkW, dspI} = {1'b0,      2'b00};
    endcase
    dspN = dsp + {dspI[1], dspI[1], dspI};

    casez (insn[15:13])
    3'b010:   {rstkW, rspI} = {1'b1,      2'b01};
    3'b011:   {rstkW, rspI} = {func_T_R,  insn[3:2]};
    default:    {rstkW, rspI} = {1'b0,      2'b00};
    endcase

    casez ({reboot, insn[15:13], insn[7], |st0})
    6'b1_???_?_?:   pcN = 0;
    6'b0_000_?_?,
    6'b0_010_?_?,
    6'b0_001_?_0:   pcN = insn[12:0];
    6'b0_011_1_?:   pcN = rst0[13:1];
    default:          pcN = pc_plus_1;
    endcase
  end

  always @(negedge resetq or posedge clk)
  begin
    if (!resetq) begin
      reboot <= 1'b1;
      { pc, dsp, st0} <= 0;
    end else begin
      reboot <= 0;
      { pc, dsp, st0} <= { pcN, dspN, st0N };
    end
  end

endmodule
