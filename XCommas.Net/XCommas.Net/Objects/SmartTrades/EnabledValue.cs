using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class EnabledValue
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("value")]
        public double? Value { get; set; }
    }
}