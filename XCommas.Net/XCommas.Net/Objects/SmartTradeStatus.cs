using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SmartTradeStatus
    {
        [EnumMember(Value = "buy_order_placed")]
        BuyOrderPlaced,
        [EnumMember(Value = "bought")]
        Bought,
        [EnumMember(Value = "stop_loss_order_placed")]
        StopLossOrderPlaced,
        [EnumMember(Value = "take_profit_order_placed")]
        TakeProfitOrderPlaced,
        [EnumMember(Value = "stop_loss_finished")]
        StopLossFinished,
        [EnumMember(Value = "take_profit_finished")]
        TakeProfitFinished,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "panic_sell_order_placed")]
        PanicSellOrderPlaced,
        [EnumMember(Value = "panic_sell_finished")]
        PanicSellFinished,
        [EnumMember(Value = "trailing_take_profit_activated")]
        TrailingTakeProfitActivated,
        [EnumMember(Value = "conditional_order_waiting_price")]
        ConditionalOrderWaitingPrice,
        [EnumMember(Value = "trailing_buy_activated")]
        TrailingBuyActivated,
        [EnumMember(Value = "simple_trade_finished")]
        SimpleTradeFinished
    }
}
