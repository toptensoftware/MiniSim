namespace MiniSim.Core
{
    /// <summary>
    /// Base class for all two input logic gates
    /// </summary>
    public abstract class TwoInputLogicGate : LogicGate
    {
        /// <summary>
        /// The first input signal
        /// </summary>
        public Signal A { get; set; }

        /// <summary>
        /// The second input signal
        /// </summary>
        public Signal B { get; set; }
    }

}
