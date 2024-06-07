using System;
using System.Collections.Generic;
using System.Text;

namespace TimeMachine
{
    /// <summary>
    /// Interface for building a <see cref="DateTime"/> object.
    /// </summary>
    internal interface IDateTimeBuilder
    {
        /// <summary>
        /// Builds the <see cref="DateTime"/> object.
        /// </summary>
        /// <returns>A <see cref="DateTime"/> object representing the specified date.</returns>
        DateTime LetsGo();
    }
}
