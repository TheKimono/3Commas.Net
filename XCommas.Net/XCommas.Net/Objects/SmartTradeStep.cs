using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace XCommas.Net.Objects
{
    public class SmartTradeStep
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("position")]
        public int? Position { get; set; }
        [JsonProperty("order_id")]
        public int OrderId { get; set; }
        [JsonProperty("smart_trade_id")]
        public int SmartTradeId { get; set; }
        [JsonProperty("is_panic_sell")]
        public bool IsPanicSell { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("trailing_last_price_updated_at")]
        public DateTime? TrailingLastPriceUpdatedAt { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("average_result_price")]
        public decimal AverageResultPrice { get; set; }
        [JsonProperty("deviation_condition")]
        public decimal DeviationCondition { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("price_method")]
        public PriceMethod PriceMethod { get; set; }
        [JsonProperty("trailing_last_price")]
        public decimal TrailingLastPrice { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("sell_method")]
        public SellMethod SellMethod { get; set; }
        [JsonProperty("sell_order_price")]
        public decimal SellOrderPrice { get; set; }
        [JsonProperty("percent")]
        public decimal Percent { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("initial_amount")]
        public decimal InitialAmount { get; set; }
        [JsonProperty("initial_total")]
        public decimal InitialTotal { get; set; }
        [JsonProperty("actual_amount")]
        public decimal ActualAmount { get; set; }
        [JsonProperty("actual_total")]
        public decimal ActualTotal { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public SmartTradeStepStatus Status { get; set; }
        [JsonProperty("market_order_id")]
        public string MarketOrderId { get; set; }
        [JsonProperty("market_class")]
        public string MarketClass { get; set; }
        [JsonProperty("price_percentage")]
        public decimal PricePercentage { get; set; }

    }
}
