using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(Moon), typeof(SpaceStation))]
    public class Planet : Matter
    {
        // TODO: Add a collection of ILife to this class and figure out how to make it usable.
    }
}