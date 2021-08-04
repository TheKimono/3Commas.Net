using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class CurrentPrice
    {
        [JsonProperty("bid")]
        public double Bid { get; set; }
        [JsonProperty("ask")]
        public double Ask { get; set; }
        [JsonProperty("last")]
        public double Last { get; set; }
        [JsonProperty("day_change_percent")]
        public double DayChangePercent { get; set; }
        [JsonProperty("quote_volume")]
        public double QuoteVolume { get; set; }
    }
}