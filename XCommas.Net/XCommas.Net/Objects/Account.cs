using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("auto_balance_period")]
        public int? AutoBalancePeriod { get; set; }
        [JsonProperty("auto_balance_portfolio_id")]
        public int? AutoBalancePortfolioId { get; set; }
        [JsonProperty("auto_balance_currency_change_limit")]
        public int? AutoBalanceCurrencyChangeLimit { get; set; }
        [JsonProperty("autobalance_enabled")]
        public bool AutoBalanceEnabled { get; set; }
        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }
        [JsonProperty("smart_trading_supported")]
        public bool SmartTradingSupported { get; set; }
        [JsonProperty("smart_selling_supported")]
        public bool SmartSellingSupported { get; set; }
        [JsonProperty("available_for_trading")]
        public Dictionary<string,string> AvailableForTrading { get; set; }
        [JsonProperty("stats_supported")]
        public bool StatsSupported { get; set; }
        [JsonProperty("trading_supported")]
        public bool TradingSupported { get; set; }
        [JsonProperty("market_buy_supported")]
        public bool MarketBuySupported { get; set; }
        [JsonProperty("conditional_buy_supported")]
        public bool ConditionalBuySupported { get; set; }
        [JsonProperty("bots_allowed")]
        public bool BotsAllowed { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("last_auto_balance")]
        public DateTime? LastAutoBalance { get; set; }
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
        [JsonProperty("auto_balance_error")]
        public string AutoBalanceError { get; set; }
        [JsonProperty("lock_reason")]
        public string LockReason { get; set; }
        [JsonProperty("btc_amount")]
        public decimal BtcAmount { get; set; }
        [JsonProperty("usd_amount")]
        public decimal UsdAmount { get; set; }
        [JsonProperty("day_profit_btc")]
        public decimal DailyProfitBtc { get; set; }
        [JsonProperty("day_profit_usd")]
        public decimal DailyProfitUsd { get; set; }
        [JsonProperty("day_profit_btc_percentage")]
        public decimal DailyProfitBtcPercentage { get; set; }
        [JsonProperty("day_profit_usd_percentage")]
        public decimal DailyProfitUsdPercentage { get; set; }
        [JsonProperty("btc_profit")]
        public decimal BtcProfit { get; set; }
        [JsonProperty("usd_profit")]
        public decimal UsdProfit { get; set; }
        [JsonProperty("usd_profit_percentage")]
        public decimal UsdProfitPercentage { get; set; }
        [JsonProperty("btc_profit_percentage")]
        public decimal BtcProfitPercentage { get; set; }
        [JsonProperty("total_btc_profit")]
        public decimal TotalBtcProfit { get; set; }
        [JsonProperty("total_usd_profit")]
        public decimal TotalUsdProfit { get; set; }
        [JsonProperty("pretty_display_type")]
        public string PrettyDisplayType { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("auto_balance_method")]
        public AccountBalanceMethod? BalanceMethod { get; set; }
    }

    public enum AccountBalanceMethod
    {
        [EnumMember(Value = "time")]
        Time,
        [EnumMember(Value = "currency_change")]
        CurrencyChange,
    }
}
