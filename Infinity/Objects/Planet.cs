using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(Moon), typeof(SpaceStation))]
    public class Planet : Matter
    {
    }
}