using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class TakeProfit
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("steps")]
        public SmartTradeStep[] Steps { get; set; }
    }
}