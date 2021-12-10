﻿namespace MiniSim.Core
{
    /// <summary>
    /// Implements a two input XOR gate
    /// </summary>
    public class XorGate : TwoInputLogicGate
    {
        protected override char Evaluate() => A.AsBool != B.AsBool ? '1' : '0';
    }

}
