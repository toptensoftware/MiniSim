using MiniSim.Core;
using System;
using Xunit;

namespace UnitTests
{
    public class ComponentTests
    {
        public string Eval(char A, char B, char Cin)
        {
            var adder = new FullAdder()
            {
                A = A,
                B = B,
                Cin = Cin,
            };

            new Circuit(adder);

            return $"{adder.Cout.Value}{adder.S.Value}";
        }

        [Fact]
        public void FullAdder()
        {
            Assert.Equal("00", Eval('0', '0', '0'));
            Assert.Equal("01", Eval('0', '0', '1'));
            Assert.Equal("01", Eval('0', '1', '0'));
            Assert.Equal("10", Eval('0', '1', '1'));
            Assert.Equal("01", Eval('1', '0', '0'));
            Assert.Equal("10", Eval('1', '0', '1'));
            Assert.Equal("10", Eval('1', '1', '0'));
            Assert.Equal("11", Eval('1', '1', '1'));
        }


    }
}
