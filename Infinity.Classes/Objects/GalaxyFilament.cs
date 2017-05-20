using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Galaxy))]
    [MaxChildren(5)]
    public class GalaxyFilament : Matter
    {
    }
}