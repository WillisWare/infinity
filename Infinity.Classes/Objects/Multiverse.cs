using Infinity.Classes.Attributes;
using Infinity.Classes.Fundamentals;

namespace Infinity.Classes.Objects
{
    [AllowedChild(typeof(Universe), typeof(SuperVoid))]
    [MaxChildren(100)]
    public class Multiverse : Matter
    {
    }
}