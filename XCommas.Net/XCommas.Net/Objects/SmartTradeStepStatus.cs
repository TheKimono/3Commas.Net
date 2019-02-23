using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SmartTradeStepStatus
    {
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "enqueued")]
        Enqueued,
        [EnumMember(Value = "need_check")]
        NeedCheck,
        [EnumMember(Value = "processed")]
        Processed,
        [EnumMember(Value = "skipped")]
        Skipped,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "panic_sold")]
        PanicSold
    }
}
