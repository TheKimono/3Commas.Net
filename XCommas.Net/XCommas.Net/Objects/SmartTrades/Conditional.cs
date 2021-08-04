using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Conditional
    {
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("trailing")]
        public Trailing Trailing { get; set; }
    }
}