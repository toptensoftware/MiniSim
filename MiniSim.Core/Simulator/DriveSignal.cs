namespace MiniSim.Core
{
    /// <summary>
    /// Implements a drive signal whose value can be changed during the simulation
    /// </summary>
    public class DriveSignal : Signal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="owner">An optional owner for this signal that will be called to update the value when queried for</param>
        public DriveSignal(Part owner = null)
        {
            _owner = owner;
        }

        /// <inheritdoc />
        public override char Value
        {
            get
            {
                _owner?.Update();
                return _value;
            }
        }

        /// <summary>
        /// Gets the part that owns this drive signal
        /// </summary>
        public Part Owner => _owner;

        /// <summary>
        /// Sets the value of this signal
        /// </summary>
        /// <param name="value">The new value</param>
        public void Drive(char value)
        {
            _value = value;
        }

        char _value;
        Part _owner;

    }

}
