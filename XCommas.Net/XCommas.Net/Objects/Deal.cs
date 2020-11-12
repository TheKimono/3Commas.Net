using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using XCommas.Net.Converters;

namespace XCommas.Net.Objects
{
    public class Deal
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string DealType { get; set; }
        [JsonProperty("bot_id")]
        public int BotId { get; set; }
        [JsonProperty("max_safety_orders")]
        public int MaxSafetyOrders { get; set; }
        [JsonProperty("deal_has_error")]
        public bool DealHasErrors { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("active_safety_orders_count")]
        public int ActiveSafetyOrdersCount { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }
        [JsonProperty("finished?")]
        public bool IsFinished { get; set; }
        [JsonProperty("current_active_safety_orders_count")]
        public int CurrentActiveSafetyOrdersCount { get; set; }
        [JsonProperty("completed_safety_orders_count")]
        public int CompletedSafetyOrdersCount { get; set; }
        [JsonProperty("cancellable?")]
        public bool IsCancellable { get; set; }
        [JsonProperty("panic_sellable?")]
        public bool IsPanicSellable { get; set; }
        [JsonProperty("trailing_enabled")]
        public bool IsTrailingEnabled { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public DealStatus Status { get; set; }
        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; set; }
        [JsonProperty("base_order_volume")]
        public decimal BaseOrderVolume { get; set; }
        [JsonProperty("safety_order_volume")]
        public decimal SafetyOrderVolume { get; set; }
        [JsonProperty("safety_order_step_percentage")]
        public decimal SafetyOrderStepPercentage { get; set; }
        [JsonProperty("bought_amount")]
        public decimal BoughtAmount { get; set; }
        [JsonProperty("bought_volume")]
        public decimal BoughtVolume { get; set; }
        [JsonProperty("bought_average_price")]
        public decimal BoughtAveragePrice { get; set; }
        [JsonProperty("sold_amount")]
        public decimal SoldAmount { get; set; }
        [JsonProperty("sold_volume")]
        public decimal SoldVolume { get; set; }
        [JsonProperty("sold_average_price")]
        public decimal? SoldAveragePrice { get; set; }
        [JsonConverter(typeof(StringEnumConverter), typeof(TakeProfitTypeNamingStrategy))]
        [JsonProperty("take_profit_type")]
        public TakeProfitType TakeProfitType { get; set; }
        [JsonProperty("final_profit")]
        public decimal? FinalProfit { get; set; }
        [JsonProperty("martingale_coefficient")]
        public decimal MartingaleCoefficient { get; set; }
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("safety_order_volume_type")]
        public VolumeType SafetyOrderVolumeType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("base_order_volume_type")]
        public VolumeType BaseOrderVolumeType { get; set; }
        [JsonProperty("from_currency")]
        public string FromCurrency { get; set; }
        [JsonProperty("to_currency")]
        public string ToCurrency { get; set; }
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("take_profit_price")]
        public decimal TakeProfitPrice { get; set; }
        [JsonProperty("final_profit_percentage")]
        public decimal? FinalProfitPercentage { get; set; }
        [JsonProperty("actual_profit_percentage")]
        public decimal? ActualProfitPercentage { get; set; }
        [JsonProperty("bot_name")]
        public string BotName { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("usd_final_profit")]
        public decimal? UsdFinalProfit { get; set; }
        [JsonProperty("actual_profit")]
        public decimal? ActualProfit { get; set; }
        [JsonProperty("actual_usd_profit")]
        public decimal? ActualUsdProfit { get; set; }
        [JsonProperty("failed_message")]
        public string FailedMessage { get; set; }
        [JsonProperty("reserved_base_coin")]
        public decimal? ReservedBaseCoin { get; set; }
        [JsonProperty("reserved_second_coin")]
        public decimal? ReservedSecondCoin { get; set; }
        [JsonProperty("trailing_deviation")]
        public decimal? TrailingDeviation { get; set; }
        [JsonProperty("trailing_max_price")]
        public decimal? TrailingMaxPrice { get; set; }
        [JsonProperty("bot_events")]
        public BotEvent[] BotEvents { get; set; }
    }
}
