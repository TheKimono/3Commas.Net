using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum TradeType
    {
        [EnumMember(Value = "buy")]
        Buy,
        [EnumMember(Value = "sell")]
        Sell
    }
}