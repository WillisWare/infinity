using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Moon), 0, 20)]
    [AllowedChild(typeof(SpaceStation), 0, 2)]
    public class Planet : Matter
    {
        // TODO: Add a collection of ILife to this class and figure out how to make it usable.
    }
}