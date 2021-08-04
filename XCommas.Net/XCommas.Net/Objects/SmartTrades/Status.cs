using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class Status
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}