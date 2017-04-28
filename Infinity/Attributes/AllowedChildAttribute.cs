using System;

namespace Infinity.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AllowedChildAttribute : Attribute
    {
        #region Constructors

        public AllowedChildAttribute(params Type[] allowedTypes)
        {
            AllowedTypes = allowedTypes;
        }

        #endregion

        #region Properties

        public Type[] AllowedTypes { get; set; }

        #endregion
    }
}
