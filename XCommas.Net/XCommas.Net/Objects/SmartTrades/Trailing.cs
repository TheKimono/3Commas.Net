using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Trailing
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("percent")]
        public double? Percent { get; set; }
    }
}