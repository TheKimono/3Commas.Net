using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects
{
    public class SimpleTradeData
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("units_to_buy")]
        public decimal Units { get; set; }
        [JsonProperty("buy_price")]
        public decimal Price { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("buy_method")]
        public SimpleTradeMethod TradeMethod { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
    }
}
