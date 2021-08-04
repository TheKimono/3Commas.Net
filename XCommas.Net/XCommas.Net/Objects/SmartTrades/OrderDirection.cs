using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades
{
    public enum OrderDirection
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }
}