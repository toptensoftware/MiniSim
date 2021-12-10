using MiniSim.Core;
using System;
using Xunit;

namespace UnitTests
{
    public class SignalTests
    {
        [Fact]
        public void ConstSignal()
        {
            Signal s = '1';
            Assert.Equal('1', s.Value);
        }

        [Fact]
        public void DriveSignal()
        {
            DriveSignal s = new DriveSignal();
            s.Drive('0');
            Assert.Equal('0', s.Value);
            s.Drive('1');
            Assert.Equal('1', s.Value);
        }


    }
}
