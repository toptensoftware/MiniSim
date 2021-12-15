using MiniSim.Core;
using System;
using Xunit;

namespace UnitTests
{
    public class LogicGateTests
    {
        char Eval(LogicGate gate)
        {
            new Circuit(gate);
            return gate.Y.Value;
        }

        [Fact]
        public void AndGate()
        {
            Assert.Equal('0', Eval(new AndGate() { A = '0', B = '0' }));
            Assert.Equal('0', Eval(new AndGate() { A = '0', B = '1' }));
            Assert.Equal('0', Eval(new AndGate() { A = '1', B = '0' }));
            Assert.Equal('1', Eval(new AndGate() { A = '1', B = '1' }));
        }

        [Fact]
        public void OrGate()
        {
            Assert.Equal('0', Eval(new OrGate() { A = '0', B = '0' }));
            Assert.Equal('1', Eval(new OrGate() { A = '0', B = '1' }));
            Assert.Equal('1', Eval(new OrGate() { A = '1', B = '0' }));
            Assert.Equal('1', Eval(new OrGate() { A = '1', B = '1' }));
        }

        [Fact]
        public void XorGate()
        {
            Assert.Equal('0', Eval(new XorGate() { A = '0', B = '0' }));
            Assert.Equal('1', Eval(new XorGate() { A = '0', B = '1' }));
            Assert.Equal('1', Eval(new XorGate() { A = '1', B = '0' }));
            Assert.Equal('0', Eval(new XorGate() { A = '1', B = '1' }));
        }

        [Fact]
        public void InverterGate()
        {
            Assert.Equal('0', Eval(new InverterGate() { A = '1' }));
            Assert.Equal('1', Eval(new InverterGate() { A = '0' }));
        }

    }
}
