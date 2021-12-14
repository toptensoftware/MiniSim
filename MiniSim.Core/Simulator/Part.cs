namespace MiniSim.Core
{
    /// <summary>
    /// Base class for all parts in a circuit
    /// </summary>
    public abstract class Part
    {
        /// <summary>
        /// Notifies the part that it should update its output value(s)
        /// </summary>
        public virtual void Update() 
        {
            if (_lastCycleNumber != Circuit.CycleNumber)
            {
                _lastCycleNumber = Circuit.CycleNumber;
                OnUpdate();
            }
        }

        /// <summary>
        /// Gets the circuit that this Part is part of
        /// </summary>
        public Circuit Circuit { get; internal set; }

        uint _lastCycleNumber;

        /// <summary>
        /// Override this method to update the output signals
        /// of this part.
        /// </summary>
        protected virtual void OnUpdate() { }
    }

}
