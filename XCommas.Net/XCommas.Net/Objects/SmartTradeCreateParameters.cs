using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace XCommas.Net.Objects
{
    public class SmartTradeCreateParameters : SmartTradeCreateParametersBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("buy_method")]
        public SimpleTradeMethod BuyMethod { get; set; }
        [JsonProperty("buy_price")]
        public decimal BuyPrice { get; set; }
        [JsonProperty("trailing_buy_enabled")]
        public bool TrailingBuyEnabled { get; set; }
        [JsonProperty("trailing_buy_step")]
        public decimal? TrailingBuyStep { get; set; }
    }

    public class SmartSellCreateParameters : SmartTradeCreateParametersBase
    {
        [JsonProperty("average_buy_price")]
        public decimal AverageBuyPrice { get; set; }
    }

    public class SmartCoverCreateParameters : SmartTradeCreateParametersBase
    {
        [JsonProperty("buy_price")]
        public decimal BuyPrice { get; set; }
        [JsonProperty("trailing_buy_enabled")]
        public bool TrailingBuyEnabled { get; set; }
        [JsonProperty("trailing_buy_step")]
        public decimal? TrailingBuyStep { get; set; }
    }

    public class SmartTradeCreateParametersBase : SmartTradeParametersBase
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("units_to_buy")]
        public decimal UnitsToBuy { get; set; }
    }

    public class SmartTradeUpdateParameters : SmartTradeParametersBase
    {
        [JsonProperty("smart_trade_id")]
        public int SmartTradeId { get; set; }

        [JsonProperty("average_buy_price")]
        public decimal? AverageBuyPrice { get; set; }
        [JsonProperty("buy_price")]
        public decimal? BuyPrice { get; set; }
        [JsonProperty("trailing_buy_enabled")]
        public bool? TrailingBuyEnabled { get; set; }
        [JsonProperty("trailing_buy_step")]
        public decimal? TrailingBuyStep { get; set; }
    }

    public abstract class SmartTradeParametersBase
    {
        [JsonProperty("take_profit_enabled")]
        public bool TakeProfitEnabled { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_type")]
        public SmartTradeCompletionType? TakeProfitType { get; set; }
        [JsonProperty("take_profit_price_condition")]
        public decimal? TakeProfitPriceCondition { get; set; }
        [JsonProperty("take_profit_percentage_condition")]
        public decimal? TakeProfitPercentageCondition { get; set; }
        [JsonProperty("take_profit_step_orders")]
        public List<TakeProfitStepOrder> TakeProfitStepOrders { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_price_method")]
        public PriceMethod? TakeProfitPriceMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_sell_method")]
        public SellMethod? TakeProfitSellMethod { get; set; }
        [JsonProperty("take_profit_sell_order_price")]
        public decimal? TakeProfitSellOrderPrice { get; set; }
        [JsonProperty("trailing_take_profit")]
        public bool? TrailingTakeProfit { get; set; }
        [JsonProperty("trailing_take_profit_step")]
        public decimal? TrailingTakeProfitStep { get; set; }
        [JsonProperty("stop_loss_enabled")]
        public bool StopLossEnabled { get; set; }
        [JsonProperty("stop_loss_price_condition")]
        public decimal? StopLossPriceCondition { get; set; }
        [JsonProperty("stop_loss_percentage_condition")]
        public decimal? StopLossPercentageCondition { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("stop_loss_price_method")]
        public PriceMethod? StopLossPriceMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("stop_loss_sell_method")]
        public SellMethod? StopLossSellMethod { get; set; }
        [JsonProperty("stop_loss_sell_order_price")]
        public decimal? StopLossSellOrderPrice { get; set; }
        [JsonProperty("trailing_stop_loss")]
        public bool? TrailingStopLoss { get; set; }
        [JsonProperty("stop_loss_timeout_enabled")]
        public bool? StopLossTimeoutEnabled { get; set; }
        [JsonProperty("stop_loss_timeout_seconds")]
        public int? StopLossTimeoutSeconds { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
    }
}
