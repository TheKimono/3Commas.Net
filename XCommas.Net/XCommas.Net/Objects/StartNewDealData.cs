using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class StartNewDealData
    {
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("skip_signal_checks")]
        public bool SkipSignalChecks { get; set; }
        [JsonProperty("skip_open_deals_checks")]
        public bool SkipOpenDealsChecks { get; set; }
    }
}
