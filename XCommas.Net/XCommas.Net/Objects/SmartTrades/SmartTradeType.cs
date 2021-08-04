using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum SmartTradeType
    {
        [EnumMember(Value = "simple_buy")]
        SimpleBuy,
        [EnumMember(Value = "simple_sell")]
        SimpleSell,
        [EnumMember(Value = "smart_sell")]
        SmartSell,
        [EnumMember(Value = "smart_trade")]
        SmartTrade,
        [EnumMember(Value = "smart_cover")]
        SmartCover,
        [EnumMember(Value = "smart_buy")]
        SmartBuy
    }
}