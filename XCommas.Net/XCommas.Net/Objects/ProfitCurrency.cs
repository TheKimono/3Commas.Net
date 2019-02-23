using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
