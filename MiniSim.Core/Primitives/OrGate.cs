namespace MiniSim.Core
{
    /// <summary>
    /// Implements a two input OR gate
    /// </summary>
    public class OrGate : TwoInputLogicGate
    {
        /// <inheritdoc />
        protected override char Evaluate() => A.AsBool || B.AsBool ? '1' : '0';
    }

}
