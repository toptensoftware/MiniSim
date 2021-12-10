using MiniSim.Core;
using System;
using Xunit;

namespace UnitTests
{
    public class LogicGateTests
    {
        [Fact]
        public void AndGate()
        {
            Assert.Equal('0', (new AndGate() { A = '0', B = '0' }).Y.Value);
            Assert.Equal('0', (new AndGate() { A = '0', B = '1' }).Y.Value);
            Assert.Equal('0', (new AndGate() { A = '1', B = '0' }).Y.Value);
            Assert.Equal('1', (new AndGate() { A = '1', B = '1' }).Y.Value);
        }

        [Fact]
        public void OrGate()
        {
            Assert.Equal('0', (new OrGate() { A = '0', B = '0' }).Y.Value);
            Assert.Equal('1', (new OrGate() { A = '0', B = '1' }).Y.Value);
            Assert.Equal('1', (new OrGate() { A = '1', B = '0' }).Y.Value);
            Assert.Equal('1', (new OrGate() { A = '1', B = '1' }).Y.Value);
        }

        [Fact]
        public void XorGate()
        {
            Assert.Equal('0', (new XorGate() { A = '0', B = '0' }).Y.Value);
            Assert.Equal('1', (new XorGate() { A = '0', B = '1' }).Y.Value);
            Assert.Equal('1', (new XorGate() { A = '1', B = '0' }).Y.Value);
            Assert.Equal('0', (new XorGate() { A = '1', B = '1' }).Y.Value);
        }

        [Fact]
        public void InverterGate()
        {
            Assert.Equal('0', (new InverterGate() { A = '1' }).Y.Value);
            Assert.Equal('1', (new InverterGate() { A = '0' }).Y.Value);
        }

    }
}
