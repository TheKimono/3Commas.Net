using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Position
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public TradeType Type { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("units")]
        public Amount Units { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("total")]
        public Amount Total { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}