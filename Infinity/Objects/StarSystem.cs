using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(Star))]
    [MaxChildren(256)]
    public class StarSystem : Matter
    {
    }
}