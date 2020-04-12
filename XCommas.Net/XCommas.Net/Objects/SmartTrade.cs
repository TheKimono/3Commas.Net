using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace XCommas.Net.Objects
{
    public class SmartTrade
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("trailing_stop_loss")]
        public bool TrailingStopLoss { get; set; }
        [JsonProperty("from_currency_id")]
        public int FromCurrencyId { get; set; }
        [JsonProperty("trailing_stop_loss_condition_percentage")]
        public decimal? TrailingStopLossConditionPercentage { get; set; }
        [JsonProperty("trailing_take_profit")]
        public bool TrailingTakeProfit { get; set; }
        [JsonProperty("stop_loss_enabled")]
        public bool StopLossEnabled { get; set; }
        [JsonProperty("take_profit_enabled")]
        public bool TakeProfitEnabled { get; set; }
        [JsonProperty("trailing_buy_enabled")]
        public bool TrailingBuyEnabled { get; set; }
        [JsonProperty("stop_loss_timeout_seconds")]
        public int StopLossTimeoutSeconds { get; set; }
        [JsonProperty("stop_loss_timeout_enabled")]
        public bool StopLossTimeoutEnabled { get; set; }
        [JsonProperty("panic_sellable")]
        public bool PanicSellable { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("finished")]
        public bool Finished { get; set; }
        [JsonProperty("cancellable")]
        public bool Cancellable { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("trailing_stop_loss_last_price_updated_at")]
        public DateTime? TrailingStopLossLastPriceUpdatedAt { get; set; }
        [JsonProperty("trailing_take_profit_last_price_updated_at")]
        public DateTime? TrailingTakeProfitLastPriceUpdatedAt { get; set; }
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public SmartTradeStatus Status { get; set; }
        [JsonProperty("take_profit_price_condition")]
        public decimal? TakeProfitPriceCondition { get; set; }
        [JsonProperty("take_profit_price_order")]
        public decimal? TakeProfitPriceOrder { get; set; }
        [JsonProperty("stop_loss_price_condition")]
        public decimal? StopLossPriceCondition { get; set; }
        [JsonProperty("stop_loss_price_order")]
        public decimal? StopLossPriceOrder { get; set; }
        [JsonProperty("units_to_buy")]
        public decimal Units { get; set; }
        [JsonProperty("buy_price")]
        public decimal Price { get; set; }
        [JsonProperty("total")]
        public decimal Total { get; set; }
        [JsonProperty("average_buy_price")]
        public decimal? AverageBuyPrice { get; set; }
        [JsonProperty("average_sell_price")]
        public decimal? AverageSellPrice { get; set; }
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
        [JsonProperty("trailing_take_profit_step")]
        public decimal? TrailingTakeProfitStep { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public SmartTradeType Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("stop_loss_price_method")]
        public PriceMethod StopLossPriceMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_price_method")]
        public PriceMethod TakeProfitPriceMethod { get; set; }
        [JsonProperty("trailing_stop_loss_last_price")]
        public decimal? TrailingStopLossLastPrice { get; set; }
        [JsonProperty("trailing_take_profit_last_price")]
        public decimal? TrailingTakeProfitLastPrice { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("buy_method")]
        public SimpleTradeMethod BuyMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_type")]
        public SmartTradeCompletionType TakeProfitType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("stop_loss_type")]
        public SmartTradeCompletionType StopLossType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("stop_loss_sell_method")]
        public SellMethod StopLossSellMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_sell_method")]
        public SellMethod TakeProfitSellMethod { get; set; }
        [JsonProperty("take_profit_sell_order_price")]
        public decimal? TakeProfitSellOrderPrice { get; set; }
        [JsonProperty("stop_loss_sell_order_price")]
        public decimal? StopLossSellOrderPrice { get; set; }
        [JsonProperty("trailing_buy_step")]
        public decimal TrailingBuyStep { get; set; }
        [JsonProperty("profit_percentage")]
        public decimal ProfitPercentage { get; set; }
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("account_market")]
        public string AccountMarket { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("from_currency_code")]
        public string FromCurrencyCode { get; set; }
        [JsonProperty("from_currency_name")]
        public string FromCurrencyName { get; set; }
        [JsonProperty("from_currency_display_name")]
        public string FromCurrencyDisplayName { get; set; }
        [JsonProperty("to_currency_code")]
        public string ToCurrencyCode { get; set; }
        [JsonProperty("to_currency_name")]
        public string ToCurrencyName { get; set; }
        [JsonProperty("to_currency_display_name")]
        public string ToCurrencyDisplayName { get; set; }
        [JsonProperty("smart_trade_steps")]
        public SmartTradeStep[] SmartTradeSteps { get; set; }
        [JsonProperty("take_profit_steps")]
        public SmartTradeStep[] TakeProfitSteps { get; set; }
        [JsonProperty("stop_loss_steps")]
        public SmartTradeStep[] StopLossSteps { get; set; }
        [JsonProperty("buy_steps")]
        public SmartTradeStep[] BuySteps { get; set; }
    }
}
