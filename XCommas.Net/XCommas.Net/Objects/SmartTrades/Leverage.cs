using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Leverage
    {
        //    "type": "waiting_targets",
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}