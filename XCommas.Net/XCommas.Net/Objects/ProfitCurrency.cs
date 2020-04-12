using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum ProfitCurrency
    {
        [EnumMember(Value = "quote_currency")]
        QuoteCurrency,
        [EnumMember(Value = "base_currency")]
        BaseCurrency,
    }
}
