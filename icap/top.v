`timescale 1ns/1ps
`default_nettype none

`define TX(n)      CLK <= 1'b0; I = (n); #3000; CLK <= 1'b1; #3000;

module top();
  reg [15:0] I;
  wire [15:0] O;
  wire BUSY;
  reg CE, CLK, WRITE;

ICAP_SPARTAN6 _icap (
  .BUSY(BUSY),
  .O(O),
  .CE(CE),
  .CLK(CLK),
  .I({
    I[8],
    I[9],
    I[10],
    I[11],
    I[12],
    I[13],
    I[14],
    I[15],
    I[0],
    I[1],
    I[2],
    I[3],
    I[4],
    I[5],
    I[6],
    I[7]
    }),
  .WRITE(WRITE)
);

  initial begin
    CE = 1;
    CLK = 0;
    WRITE = 0;
    I = 0;
    $dumpfile("/data/test.vcd"); $dumpvars(0);
    #9000;
    CE = 0;
    `TX(16'hffff);
    `TX(16'hffff);
    `TX(16'hffff);
    `TX(16'hffff);
    `TX(16'hffff);
    `TX(16'hffff);

    `TX(16'haa99);
    `TX(16'h5566);

    `TX(16'h2000);
    `TX(16'h2000);
    `TX(16'h29c1);

    CLK = 0; #3000;
    CE = 1; #3000;
    WRITE = 1; #3000;
    CLK = 1; #3000; CLK = 0; #3000;
    CE = 0; #3000;

    `TX(16'h2000);
    `TX(16'h2000);
    `TX(16'h2000);
    `TX(16'h2000);
    `TX(16'h2000);
    #100;

    $finish();
  end
  
endmodule

