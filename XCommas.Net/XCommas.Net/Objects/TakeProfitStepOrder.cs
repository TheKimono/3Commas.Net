using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects
{
    public class TakeProfitStepOrder
    {
        [JsonProperty("percent")]
        public double Percent { get; set; }
        [JsonProperty("price")]
        public double? Price { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("price_method")]
        public PriceMethod? PriceMethod { get; set; }
        [JsonProperty("price_percentage")]
        public double? PricePercentage { get; set; }
    }
}
