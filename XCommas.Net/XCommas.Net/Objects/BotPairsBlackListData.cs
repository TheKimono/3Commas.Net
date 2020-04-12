using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class BotPairsBlackListData
    {
        [JsonProperty("pairs")]
        public string[] Pairs { get; set; }
    }
}
