using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(AsteroidBelt), typeof(StarSystem))]
    [MaxChildren(256)]
    public class Galaxy : Matter
    {
    }
}