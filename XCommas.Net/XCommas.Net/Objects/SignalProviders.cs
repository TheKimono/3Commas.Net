using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SignalProviders
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "paid")]
        Paid,
        [EnumMember(Value = "free")]
        Free
    }
}