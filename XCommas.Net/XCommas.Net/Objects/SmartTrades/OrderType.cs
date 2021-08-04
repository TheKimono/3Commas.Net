using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum OrderType
    {
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "limit")]
        Limit
    }
}