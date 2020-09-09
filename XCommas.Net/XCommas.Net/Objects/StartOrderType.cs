using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum StartOrderType
    {
        [EnumMember(Value = "limit")]
        Limit,
        [EnumMember(Value = "market")]
        Market
    }
}