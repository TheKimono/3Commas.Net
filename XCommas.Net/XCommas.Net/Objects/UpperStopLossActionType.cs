using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum UpperStopLossActionType
    {
        [EnumMember(Value = "stop_bot")]
        StopBot,
        [EnumMember(Value = "stop_bot_and_buy")]
        BuyBaseCurrencyAndStop,
        [EnumMember(Value = "stop_bot_and_close_position")]
        ClosePositionAndStop
    }
}