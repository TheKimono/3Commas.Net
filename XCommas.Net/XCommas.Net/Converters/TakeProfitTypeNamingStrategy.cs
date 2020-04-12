using Newtonsoft.Json.Serialization;

namespace XCommas.Net.Converters
{
    public class TakeProfitTypeNamingStrategy : NamingStrategy
    {
        protected override string ResolvePropertyName(string name)
        {
            if (name == "total") return "total_bought_volume";
            if (name == "base") return "base_order_volume";
            if (name == "total_bought_volume") return "total";
            if (name == "base_order_volume") return "base";

            return string.Empty;
        }
    }
}
