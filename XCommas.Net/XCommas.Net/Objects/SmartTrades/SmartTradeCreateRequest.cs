using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class SmartTradeCreateRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("instant")]
        public bool? Instant { get; set; }
        [JsonProperty("skip_enter_step")]
        public bool? SkipEnterStep { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("take_profit")]
        public TakeProfit TakeProfit { get; set; }
        [JsonProperty("stop_loss")]
        public StopLoss StopLoss { get; set; }
    }
}