using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SmartTradeType
    {
        [EnumMember(Value = "SmartTrade::Classic")]
        Classic,
        [EnumMember(Value = "SmartTrade::ConditionalBuy")]
        ConditionalBuy,
        [EnumMember(Value = "SmartTrade::SmartSale")]
        SmartSale,
        [EnumMember(Value = "SmartTrade::SellBuyBack")]
        SellBuyBack,
        [EnumMember(Value = "SmartTrade::ConditionalSell")]
        ConditionalSell,
        [EnumMember(Value = "SmartTrade::SimpleBuy")]
        SimpleBuy,
        [EnumMember(Value = "SmartTrade::ConditionalSimpleBuy")]
        ConditionalSimpleBuy,
        [EnumMember(Value = "SmartTrade::ConditionalSimpleSell")]
        ConditionalSimpleSell,
        [EnumMember(Value = "SmartTrade::SimpleSell")]
        SimpleSell
    }
}
