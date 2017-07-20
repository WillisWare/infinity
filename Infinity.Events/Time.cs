using System;

namespace WillisWare.Infinity.Events
{
    #region Arguments

    /// <summary>
    /// Represents the arguments necessary to handle a time tick event.
    /// </summary>
    public sealed class TimeTickEventArgs : EventArgs
    {
        #region Properties

        public long Ticks { get; set; }

        #endregion
    }

    #endregion
}
