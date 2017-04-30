using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(Star))]
    [MaxChildren(256)]
    public class StarSystem : Matter
    {
    }
}