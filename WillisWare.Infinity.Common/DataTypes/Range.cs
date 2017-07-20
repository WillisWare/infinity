using Newtonsoft.Json;

namespace WillisWare.Infinity.Common.DataTypes
{
    /// <summary>
    /// Represents a range of acceptable values, for use in limiting object instances in procedural generation.
    /// </summary>
    public sealed class Range
    {
        #region Constructors

        /// <summary>
        /// Default constructor. Initializes an instance of this class with the specified minimum and maximum values.
        /// </summary>
        /// <param name="minimum">A <see cref="long"/> value containing the lower boundary of the range.</param>
        /// <param name="maximum">A <see cref="long"/> value containing the upper boundary of the range.</param>
        public Range(long minimum, long maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the upper boundary of the range.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public long Maximum { get; set; }

        /// <summary>
        /// Gets or sets the lower boundary of the range.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public long Minimum { get; set; }

        #endregion
    }
}
