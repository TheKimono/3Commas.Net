using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class SmartTradeAddFundsParameters
    {
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
        [JsonProperty("is_market")]
        public bool IsMarket { get; set; }
        [JsonProperty("rate")]
        public decimal? Rate { get; set; }
        [JsonProperty("smart_trade_id")]
        public int SmartTradeId { get; set; }
        [JsonProperty("response_type")]
        public string ResponseType { get; set; } = "step";
    }
}
