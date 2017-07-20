using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Fundamentals;

namespace WillisWare.Infinity.Classes.Objects
{
    [AllowedChild(typeof(Star), 1, 256)]
    public class StarSystem : Matter
    {
    }
}