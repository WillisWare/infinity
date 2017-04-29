using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(Galaxy))]
    [MaxChildren(5)]
    public class GalaxyFilament : Matter
    {
    }
}