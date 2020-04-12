using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum DealOrder
    {
        [EnumMember(Value = "created_at")]
        CreatedAt,
        [EnumMember(Value = "closed_at")]
        ClosedAt,
    }
}
