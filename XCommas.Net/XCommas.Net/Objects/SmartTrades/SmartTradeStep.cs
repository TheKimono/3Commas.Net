using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects.SmartTrades
{
    public class SmartTradeStep
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("units")]
        public Amount Units { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("volume")]
        public double Volume { get; set; }
        [JsonProperty("total")]
        public double Total { get; set; }
        [JsonProperty("trailing")]
        public Trailing Trailing { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
        [JsonProperty("data")]
        public SmartTradeStepData Data { get; set; }
        [JsonProperty("position")]
        public int Position { get; set; }
    }
}