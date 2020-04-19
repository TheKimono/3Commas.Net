using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects
{
    public class TakeProfitStepOrder
    {
        [JsonProperty("position")]
        public int Position { get; set; }
        [JsonProperty("percent")]
        public decimal Percent { get; set; }
        [JsonProperty("price")]
        public decimal? Price { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("price_method")]
        public PriceMethod? PriceMethod { get; set; }
        [JsonProperty("price_percentage")]
        public decimal? PricePercentage { get; set; }
    }
}
