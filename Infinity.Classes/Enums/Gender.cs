using System.Runtime.Serialization;

namespace Infinity.Classes.Enums
{
    public enum Gender
    {
        [EnumMember(Value = "none")]
        Unknown,
        [EnumMember(Value = "female")]
        Female,
        [EnumMember(Value = "both")]
        Hermaphroditic,
        [EnumMember(Value = "male")]
        Male
    }
}
