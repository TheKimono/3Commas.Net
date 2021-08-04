using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Profit
    {
        [JsonProperty("volume")]
        public double Volume { get; set; }
        [JsonProperty("usd")]
        public double Usd { get; set; }
        [JsonProperty("percent")]
        public double Percent { get; set; }
    }
}