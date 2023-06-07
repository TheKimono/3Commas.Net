using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class DealAddFundsParameters
    {
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
        [JsonProperty("is_market")]
        public bool IsMarket { get; set; }
        [JsonProperty("rate")]
        public decimal? Rate { get; set; }
        [JsonProperty("deal_id")]
        public long DealId { get; set; }
        [JsonProperty("response_type")]
        public string ResponseType { get; set; } = "deal";
    }
}
