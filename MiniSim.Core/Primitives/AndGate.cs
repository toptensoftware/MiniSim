namespace MiniSim.Core
{
    /// <summary>
    /// Implements a two input AND gate
    /// </summary>
    public class AndGate : TwoInputLogicGate
    {
        /// <inheritdoc />
        protected override char Evaluate() => A.AsBool && B.AsBool ? '1' : '0';
    }

}
