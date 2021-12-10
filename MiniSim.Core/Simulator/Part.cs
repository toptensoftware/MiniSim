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
        public virtual void Update() { }
    }

}
