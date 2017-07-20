using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(DarkEnergy), 0, 1)]
    [AllowedChild(typeof(GalacticSupercluster), 1, 1)]
    public class Universe : Matter
    {
    }
}