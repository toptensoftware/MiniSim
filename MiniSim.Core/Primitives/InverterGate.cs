using System;

namespace MiniSim.Core
{

    /// <summary>
    /// Implements an inverter gate
    /// </summary>
    public class InverterGate : LogicGate
    {
        public Signal A { get; set; }

        /// <inheritdoc />
        protected override char Evaluate() => A.AsBool ? '0' : '1';
    }

}
