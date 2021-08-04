using System;
using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class SmartTrade
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
        [JsonProperty("account")]
        public Account Account { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("instant")]
        public bool Instant { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
        [JsonProperty("leverage")]
        public Leverage Leverage { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("take_profit")]
        public TakeProfit TakeProfit { get; set; }
        [JsonProperty("stop_loss")]
        public StopLoss StopLoss { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
        [JsonProperty("skip_enter_step")]
        public bool SkipEnterStep { get; set; }
        [JsonProperty("data")]
        public SmartTradeData Data { get; set; }
        [JsonProperty("profit")]
        public Profit Profit { get; set; }
        [JsonProperty("margin")]
        public Amount Margin { get; set; }
        [JsonProperty("is_position_not_filled")]
        public bool IsPositionNotFilled { get; set; }
    }
}
