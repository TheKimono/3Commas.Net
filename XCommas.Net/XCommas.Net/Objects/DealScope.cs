using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum DealScope
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "all")]
        All
    }
}
