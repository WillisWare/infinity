using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(AsteroidBelt), typeof(StarSystem))]
    [MaxChildren(256)]
    public class Galaxy : Matter
    {
    }
}