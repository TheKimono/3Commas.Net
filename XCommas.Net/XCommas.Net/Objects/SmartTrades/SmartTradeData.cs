using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects.SmartTrades
{
    public class SmartTradeData
    {
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("current_price")]
        public CurrentPrice CurrentPrice { get; set; }
        [JsonProperty("target_price_type")]
        public string TargetPriceType { get; set; }
        [JsonProperty("base_order_finished")]
        public bool BaseOrderFinished { get; set; }
        [JsonProperty("missing_funds_to_close")]
        public double MissingFundsToClose { get; set; }
        [JsonProperty("liquidation_price")]
        public double? LiquidationPrice { get; set; }
        [JsonProperty("average_enter_price")]
        public double AverageEnterPrice { get; set; }
        [JsonProperty("average_close_price")]
        public double? AverageClosePrice { get; set; }
        [JsonProperty("average_enter_price_without_commission")]
        public double AverageEnterPriceWithoutCommission { get; set; }
        [JsonProperty("average_close_price_without_commission")]
        public double? AverageClosePriceWithoutCommission { get; set; }
        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }
        [JsonProperty("add_funds_available")]
        public bool AddFundsAvailable { get; set; }
        [JsonProperty("force_start_available")]
        public bool ForceStartAvailable { get; set; }
        [JsonProperty("force_process_available")]
        public bool ForceProcessAvailable { get; set; }
        [JsonProperty("cancel_available")]
        public bool CancelAvailable { get; set; }
        [JsonProperty("finished")]
        public bool Finished { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public SmartTradeType Type { get; set; }
    }
}