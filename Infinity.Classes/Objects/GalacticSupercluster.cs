using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(GalaxyFilament))]
    [MaxChildren(10)]
    public class GalacticSupercluster : Matter
    {
    }
}