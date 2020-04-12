using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class CurrencyRate
    {
        [JsonProperty("last")]
        public decimal Last { get; set; }
        [JsonProperty("bid")]
        public decimal Bid { get; set; }
        [JsonProperty("ask")]
        public decimal Ask { get; set; }
        [JsonProperty("minPrice")]
        public decimal MinPrice { get; set; }
        [JsonProperty("priceStep")]
        public decimal PriceStep { get; set; }
        [JsonProperty("minLotSize")]
        public decimal MinLotSize { get; set; }
        [JsonProperty("maxLotSize")]
        public decimal MaxLotSize { get; set; }
        [JsonProperty("lotStep")]
        public decimal LotStep { get; set; }
        [JsonProperty("minTotal")]
        public decimal MinTotal { get; set; }
    }
}
