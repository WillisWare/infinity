using System;

namespace WillisWare.Infinity.Classes.Attributes
{
    /// <summary>
    /// Decorates a class in this project with constraints on child types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class AllowedChildAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        /// Default constructor. Initializes an instance of this class with the provided values.
        /// </summary>
        /// <param name="allowedType"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        public AllowedChildAttribute(Type allowedType, long minimum, long maximum)
        {
            AllowedType = new AllowedChildAttributeValue(allowedType, minimum, maximum);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the allowed class types of children for an instance.
        /// </summary>
        public AllowedChildAttributeValue AllowedType { get; set; }

        #endregion
    }
}
