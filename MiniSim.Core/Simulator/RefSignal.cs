using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSim.Core
{
    /// <summary>
    /// A signal that resolves its value by referencing another signal
    /// that isn't resolved until runtime
    /// </summary>
    public class RefSignal : Signal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="getSource">A callback to get the referenced source signal</param>
        public RefSignal(Func<Signal> getSource)
        {
            _getSource = getSource;
        }

        Func<Signal> _getSource;

        /// <inheritdoc />
        public override char Value => _getSource().Value;
    }

}
