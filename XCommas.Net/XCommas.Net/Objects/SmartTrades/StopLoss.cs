using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects.SmartTrades
{
    public class StopLoss
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("breakeven")]
        public bool Breakeven { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("conditional")]
        public Conditional Conditional { get; set; }
        [JsonProperty("timeout")]
        public EnabledValue Timeout { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}