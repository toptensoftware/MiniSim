using System;

namespace MiniSim.Core
{
    /// <summary>
    /// Base class for all logic gates
    /// </summary>
    public abstract class LogicGate : Part
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LogicGate()
        {
            _y = new DriveSignal(this);
        }

        /// <summary>
        /// The output signal from this gate
        /// </summary>
        public Signal Y => _y;

        DriveSignal _y;

        /// <inheritdoc />
        protected override void OnUpdate()
        {
            _y.Drive(Evaluate());
        }

        /// <summary>
        /// Override this method to evaluate output value of this logic gate
        /// </summary>
        /// <returns>The evaluated value</returns>
        protected abstract char Evaluate();
    }

}
