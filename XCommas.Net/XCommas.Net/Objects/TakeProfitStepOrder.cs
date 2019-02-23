using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class TakeProfitStepOrder
    {
        [JsonProperty("percent")]
        public double Percent { get; set; }
        [JsonProperty("price")]
        public double? Price { get; set; }
        [JsonProperty("price_method")]
        public string PriceMethod { get; set; }
        [JsonProperty("price_percentage")]
        public double? PricePercentage { get; set; }
    }
}
