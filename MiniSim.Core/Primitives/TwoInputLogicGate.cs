namespace MiniSim.Core
{
    /// <summary>
    /// Base class for all two input logic gates
    /// </summary>
    public abstract class TwoInputLogicGate : LogicGate
    {
        public Signal A { get; set; }
        public Signal B { get; set; }
    }

}
