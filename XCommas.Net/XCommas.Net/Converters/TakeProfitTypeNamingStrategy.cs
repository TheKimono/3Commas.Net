using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace XCommas.Net.Converters
{
    public class TakeProfitTypeNamingStrategy : NamingStrategy
    {
        protected override string ResolvePropertyName(string name)
        {
            if (name == "total") return "total_bought_volume";
            if (name == "base") return "base_order_volume";

            return string.Empty;
        }
    }
}
