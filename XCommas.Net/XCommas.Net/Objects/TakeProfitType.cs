using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum TakeProfitType
    {
        [EnumMember(Value = "base")]
        Base,
        [EnumMember(Value = "total")]
        Total
    }
}
