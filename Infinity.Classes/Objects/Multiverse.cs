using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Universe), typeof(SuperVoid))]
    [MaxChildren(100)]
    public class Multiverse : Matter
    {
    }
}