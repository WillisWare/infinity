using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(Asteroid), typeof(Planet))]
    public class Star : Matter
    {
    }
}