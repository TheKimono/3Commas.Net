using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum PriceMethod
    {
        [EnumMember(Value = "bid")]
        Bid,
        [EnumMember(Value = "ask")]
        Ask,
        [EnumMember(Value = "last")]
        Last,
    }
}
