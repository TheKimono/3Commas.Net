using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class MarketplaceItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }
        [JsonProperty("strategy_type")]
        public string StrategyType { get; set; }
        [JsonProperty("strategy_key")]
        public string StrategyKey { get; set; }
    }
}
