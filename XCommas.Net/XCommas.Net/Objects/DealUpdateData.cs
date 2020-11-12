using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class DealUpdateData
    {
        public DealUpdateData(int dealId)
        {
            DealId = dealId;
        }

        [JsonProperty("deal_id")]
        public int DealId { get; set; }
        [JsonProperty("take_profit")]
        public decimal? TakeProfit { get; set; }
        [JsonProperty("profit_currency")]
        public ProfitCurrency? ProfitCurrency { get; set; }
        [JsonProperty("take_profit_type")]
        public TakeProfitType? TakeProfitType { get; set; }
        [JsonProperty("trailing_enabled")]
        public bool? TrailingEnabled { get; set; }
        [JsonProperty("trailing_deviation")]
        public decimal? TrailingDeviation { get; set; }
        [JsonProperty("stop_loss_percentage")]
        public decimal? StopLossPercentage { get; set; }
        [JsonProperty("max_safety_orders")]
        public int? MaxSafetyOrders { get; set; }
        [JsonProperty("active_safety_orders_count")]
        public int? MaxSafetyOrdersCount { get; set; }
        [JsonProperty("stop_loss_timeout_enabled")]
        public bool? StopLossTimeoutEnabled { get; set; }
        [JsonProperty("stop_loss_timeout_in_seconds")]
        public int? StopLossTimeoutInSeconds { get; set; }
        [JsonProperty("tsl_enabled")]
        public bool? TslEnabled { get; set; }
        [JsonProperty("stop_loss_type")]
        public StopLossType? StopLossType { get; set; }
    }
}