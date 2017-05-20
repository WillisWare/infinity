using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Star))]
    [MaxChildren(256)]
    public class StarSystem : Matter
    {
    }
}