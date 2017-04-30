using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(GalaxyFilament))]
    [MaxChildren(10)]
    public class GalacticSupercluster : Matter
    {
    }
}