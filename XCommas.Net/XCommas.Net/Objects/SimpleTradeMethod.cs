using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SimpleTradeMethod
    {
        [EnumMember(Value = "limit")]
        Limit,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "conditional")]
        Conditional,
    }
}
