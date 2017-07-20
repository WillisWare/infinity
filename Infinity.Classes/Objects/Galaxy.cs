using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(AsteroidBelt), 0, 1)]
    [AllowedChild(typeof(StarSystem), 1, 256)]
    public class Galaxy : Matter
    {
    }
}