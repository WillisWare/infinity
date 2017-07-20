using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Asteroid), 0, 999)]
    public class AsteroidBelt : Matter
    {
    }
}