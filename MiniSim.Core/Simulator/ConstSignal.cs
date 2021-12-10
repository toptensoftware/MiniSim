namespace MiniSim.Core
{
    /// <summary>
    /// Implements a constant signal
    /// </summary>
    public class ConstSignal : Signal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">The value of the signal</param>
        public ConstSignal(char value)
        {
            _value = value;
        }

        /// <inheritdoc />
        public override char Value => _value;

        char _value;
    }

}
