using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(Galaxy))]
    [MaxChildren(5)]
    public class GalaxyFilament : Matter
    {
    }
}