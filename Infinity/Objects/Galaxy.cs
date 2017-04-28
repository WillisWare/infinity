using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(AsteroidBelt), typeof(StarSystem))]
    public class Galaxy : Matter
    {
    }
}