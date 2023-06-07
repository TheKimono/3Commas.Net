using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum LowerStopLossActionType
    {
        [EnumMember(Value = "stop_bot")]
        StopBot,
        [EnumMember(Value = "stop_bot_and_sell")]
        SellBaseCurrencyAndStop,
        [EnumMember(Value = "stop_bot_and_close_position")]
        ClosePositionAndStop
    }
}