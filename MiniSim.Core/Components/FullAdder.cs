using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSim.Core
{
    /// <summary>
    /// Implements a 1-bit full adder
    /// </summary>
    public class FullAdder : Part
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FullAdder()
        {
            var refA = new RefSignal(() => A);
            var refB = new RefSignal(() => B);
            var refCin = new RefSignal(() => Cin);


            var xor1 = new XorGate()
            {
                A = refA,
                B = refB,
            };

            var xor2 = new XorGate()
            {
                A = xor1.Y,
                B = refCin,
            };

            var and1 = new AndGate()
            {
                A = refCin,
                B = xor1.Y,
            };

            var and2 = new AndGate()
            {
                A = refA,
                B = refB,
            };

            var or1 = new OrGate()
            {
                A = and1.Y,
                B = and2.Y,
            };

            S = xor2.Y;
            Cout = or1.Y;

        }

        /// <summary>
        /// The first input value
        /// </summary>
        public Signal A { get; set; }

        /// <summary>
        /// The second input value
        /// </summary>
        public Signal B { get; set; }

        /// <summary>
        /// A carry-in signal 
        /// </summary>
        public Signal Cin { get; set; }

        /// <summary>
        /// The output sum
        /// </summary>
        public Signal S { get; }

        /// <summary>
        /// A carry-out signal
        /// </summary>
        public Signal Cout { get; }
    }
}
