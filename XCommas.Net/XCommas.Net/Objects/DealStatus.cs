using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum DealStatus
    {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "base_order_placed")]
        BaseOrderplaced,
        [EnumMember(Value = "bought")]
        Bought,
        [EnumMember(Value = "bought_safety_pending")]
        BoughtStatusPending,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "panic_sell_pending")]
        PanicSellPending,
        [EnumMember(Value = "panic_sell_order_placed")]
        PanicSellOrderPlaced,
        [EnumMember(Value = "panic_sold")]
        PanicSold,
        [EnumMember(Value = "cancel_pending")]
        CancelPending,
        [EnumMember(Value = "stop_loss_pending")]
        StopLossPending,
        [EnumMember(Value = "stop_loss_finished")]
        StopLossFinished,
        [EnumMember(Value = "stop_loss_order_placed")]
        StopLossOrderPlaced,
        [EnumMember(Value = "switched")]
        Switched,
        [EnumMember(Value = "switched_take_profit")]
        SwitchedTakeProfit,
        [EnumMember(Value = "ttp_activated")]
        TtpActivated,
        [EnumMember(Value = "ttp_order_placed")]
        TtpOrderPlaced,
        [EnumMember(Value = "liquidated")]
        Liquidated
    }
}
