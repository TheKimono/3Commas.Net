using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class AddFundsToSmartTradeParams
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("order_type")]
        public string OrderType { get; set; }
        [JsonProperty("units")]
        public Amount Units { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
    }
}