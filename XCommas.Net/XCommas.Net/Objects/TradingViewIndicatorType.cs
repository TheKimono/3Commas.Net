using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum TradingViewIndicatorType
    {
        [EnumMember(Value = "buy_or_strong_buy")]
        Buy,
        [EnumMember(Value = "strong_buy")]
        StrongBuy
    }
}
