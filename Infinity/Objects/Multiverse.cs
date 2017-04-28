using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(Universe), typeof(SuperVoid))]
    public class Multiverse : Matter
    {
        #region Constructors

        public Multiverse()
            : base("Multiverse")
        {
        }

        #endregion
    }
}