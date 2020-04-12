using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class PieChartPiece
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("coinmarketcapid")]
        public string CoinMarketCapId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("y")]
        public decimal Y { get; set; }
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("btc_value")]
        public decimal BtcValue { get; set; }
        [JsonProperty("usd_value")]
        public decimal UsdValue { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
    }
}
