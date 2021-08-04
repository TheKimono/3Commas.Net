using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum OrderBy
    {
        [EnumMember(Value = "created_at")]
        CreatedAt,
        [EnumMember(Value = "updated_at")]
        UpdatedAt,
        [EnumMember(Value = "closed_at")]
        ClosedAt,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "profit")]
        Profit,
        [EnumMember(Value = "profit_percentage ")]
        ProfitPercentage
    }
}