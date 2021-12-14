using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSim.Core
{
    /// <summary>
    /// The Circuit class manages the circuit as a whole and provides
    /// services to manage the simulation
    /// </summary>
    public class Circuit
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parts">An array of parts to add to the circuit</param>
        public Circuit(params Part[] parts)
        {
            foreach (var p in parts)
            {
                AddPart(p);
            }

        }

        /// <summary>
        /// Adds a part, and all its connected parts, to the circuit
        /// </summary>
        /// <param name="part">The part to add</param>
        public void AddPart(Part part)
        {
            if (part == null)
                return;

            if (part.Circuit == this)
                return;

            _parts.Add(part);
            part.Circuit = this;

            foreach (var connectedPart in GetConnectedParts(part))
            {
                AddPart(connectedPart);
            }
        }

        /// <summary>
        /// Starts the next simulation cycle
        /// </summary>
        /// <remarks>
        /// Calling this method causes all parts to be
        /// re-evalated, assuming all input signals may
        /// have changed.
        /// </remarks>
        public void StartCycle()
        {
            _cycleNumber++;
        }

        /// <summary>
        /// Finds all the parts connected to the specified part
        /// </summary>
        /// <param name="part">The part whose connected parts are to be returned</param>
        /// <returns>An enumerable collection of connected parts</returns>
        IEnumerable<Part> GetConnectedParts(Part part)
        {
            foreach (var pi in part.GetType().GetProperties())
            {
                if (pi.PropertyType.IsAssignableTo(typeof(Part)))
                {
                    var connectedPart = (Part)pi.GetValue(part);
                    yield return connectedPart;
                }
            }
        }

        /// <summary>
        /// Gets the current simulation cycle number
        /// </summary>
        public uint CycleNumber => _cycleNumber;

        uint _cycleNumber = 1;
        List<Part> _parts = new();
    }
}
