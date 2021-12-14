using System;

namespace MiniSim.Core
{

    /// <summary>
    /// Implements an inverter gate
    /// </summary>
    public class InverterGate : LogicGate
    {
        /// <summary>
        /// The input signal
        /// </summary>
        public Signal A { get; set; }

        /// <inheritdoc />
        protected override char Evaluate() => A.AsBool ? '0' : '1';
    }

}
