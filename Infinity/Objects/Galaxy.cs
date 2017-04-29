using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(AsteroidBelt), typeof(StarSystem))]
    [MaxChildren(256)]
    public class Galaxy : Matter
    {
    }
}