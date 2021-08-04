using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum SmartTradeStatus
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "successfully_finished")]
        SuccessfullyFinished,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "failed")]
        Failed
    }
}