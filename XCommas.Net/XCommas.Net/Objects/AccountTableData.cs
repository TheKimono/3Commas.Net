using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class AccountTableData
    {
        [JsonProperty("account_state_entry_id")]
        public long AccountStateEntryId { get; set; }
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }
        [JsonProperty("currency_icon")]
        public string CurrencyIconUrl { get; set; }
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }
        [JsonProperty("position")]
        public decimal Position { get; set; }
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("current_price_usd")]
        public decimal CurrentPriceUsd { get; set; }
        [JsonProperty("day_change_percent")]
        public decimal? DayChangePercent { get; set; }
        [JsonProperty("btc_value")]
        public decimal BtcValue { get; set; }
        [JsonProperty("usd_value")]
        public decimal UsdValue { get; set; }
        [JsonProperty("on_orders")]
        public decimal OnOrders { get; set; }
        [JsonProperty("134645")]
        public int AccountId { get; set; }
    }
}
