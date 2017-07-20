using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Universe), 1, 100)]
    [AllowedChild(typeof(SuperVoid), 0, 1)]
    public class Multiverse : Matter
    {
    }
}