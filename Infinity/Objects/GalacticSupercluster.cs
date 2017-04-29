using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(GalaxyFilament))]
    [MaxChildren(10)]
    public class GalacticSupercluster : Matter
    {
    }
}