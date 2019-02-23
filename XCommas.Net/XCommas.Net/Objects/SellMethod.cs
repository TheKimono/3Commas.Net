using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SellMethod
    {
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "limit")]
        Limit,
    }
}
