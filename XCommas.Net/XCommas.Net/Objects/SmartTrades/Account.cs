using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("market")]
        public string Market { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}