using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Amount
    {
        [JsonProperty("value")]
        public double? Value { get; set; }
        [JsonProperty("value_without_commission")]
        public double? ValueWithoutCommission { get; set; }
        [JsonProperty("editable")]
        public bool? Editable { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public PriceType? Type { get; set; }
        [JsonProperty("percent")]
        public double? Percent { get; set; }
    }
}