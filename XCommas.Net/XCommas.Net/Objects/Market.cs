using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class Market
    {
        [JsonProperty("market_name")]
        public string Name { get; set; }
        [JsonProperty("market_url")]
        public string Url { get; set; }
        [JsonProperty("market_icon")]
        public string IconUrl { get; set; }
        [JsonProperty("help_link")]
        public string HelpLink { get; set; }
    }
}
