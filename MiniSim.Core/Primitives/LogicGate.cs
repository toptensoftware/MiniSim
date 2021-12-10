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
        public override void Update()
        {
            _y.Drive(Evaluate());
        }

        protected abstract char Evaluate();
    }

}
