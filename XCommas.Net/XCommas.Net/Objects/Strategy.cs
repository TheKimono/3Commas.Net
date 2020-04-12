using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum Strategy
    {
        [EnumMember(Value = "long")]
        Long,
        [EnumMember(Value = "short")]
        Short
    }
}
