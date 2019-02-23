using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum VolumeType
    {
        [EnumMember(Value = "quote_currency")]
        QuoteCurrency,
        [EnumMember(Value = "base_currency")]
        BaseCurrency,
        [EnumMember(Value = "percent")]
        Percent,
        [EnumMember(Value = "xbt")]
        Xbt
    }
}
