namespace MiniSim.Core
{
    /// <summary>
    /// Base class for all signals
    /// </summary>
    public abstract class Signal : Part
    {
        /// <summary>
        /// Gets the value of the signal
        /// </summary>
        public abstract char Value { get; }

        /// <summary>
        /// Implicit conversion operator converts a char to a signal
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Signal(char value) => new ConstSignal(value);

        /// <inheritdoc />
        public override string ToString()
        {
            return $"'{Value}'";
        }

        /// <summary>
        /// Gets the value of the signal as a boolean
        /// </summary>
        public bool AsBool => Value == '1';
    }

}
