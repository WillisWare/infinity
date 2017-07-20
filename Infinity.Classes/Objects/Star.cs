using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Asteroid), 0, 256)]
    [AllowedChild(typeof(Planet), 1, 20)]
    public class Star : Matter
    {
    }
}