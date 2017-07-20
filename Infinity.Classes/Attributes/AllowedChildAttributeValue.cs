using System;
using WillisWare.Infinity.Common.DataTypes;

namespace WillisWare.Infinity.Classes.Attributes
{
    /// <summary>
    /// Represents an attribute value specifying a class type with minimum and maximum limits for population size.
    /// </summary>
    public sealed class AllowedChildAttributeValue
    {
        #region Constructors

        /// <summary>
        /// Default constructor. Initializes an instance of this class with a <see cref="Type"/>, and minimum and maximum population limits.
        /// </summary>
        /// <param name="type">A <see cref="Type"/> identifier specifying the class type of the child.</param>
        /// <param name="minimum">A <see cref="long"/> value containing the lower boundary of the population limit.</param>
        /// <param name="maximum">A <see cref="long"/> value containing the upper boundary of the population limit.</param>
        public AllowedChildAttributeValue(Type type, long minimum, long maximum)
        {
            ChildType = type;
            PopulationLimit = new Range(minimum, maximum);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the class type of the child.
        /// </summary>
        public Type ChildType { get; set; }

        /// <summary>
        /// Gets or sets the boundaries of the population limit.
        /// </summary>
        public Range PopulationLimit { get; set; }

        #endregion
    }
}
