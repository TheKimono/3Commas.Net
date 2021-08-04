using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum PriceType
    {
        [EnumMember(Value = "bid")]
        Bid,
        [EnumMember(Value = "ask")]
        Ask,
        [EnumMember(Value = "last")]
        Last
    }
}