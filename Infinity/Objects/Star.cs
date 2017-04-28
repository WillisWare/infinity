using Infinity.Attributes;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    [AllowedChild(typeof(Asteroid), typeof(Planet))]
    public class Star : Matter
    {
    }
}