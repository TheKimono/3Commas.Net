using Newtonsoft.Json;
using System.Collections.Generic;

namespace XCommas.Net.Objects
{
    public class BotStats
    {
        [JsonProperty("overall_stats")]
        public Dictionary<string, decimal> OverallStats { get; set; }
        [JsonProperty("today_stats")]
        public Dictionary<string, decimal> TodayStats { get; set; }
        [JsonProperty("profits_in_usd")]
        public UsdProfits UsdProfits { get; set; }
    }

    public class UsdProfits
    {
        [JsonProperty("overall_usd_profit")]
        public decimal Overall { get; set; }
        [JsonProperty("today_usd_profit")]
        public decimal Today { get; set; }
        [JsonProperty("active_deals_usd_profit")]
        public decimal ActiveDeals { get; set; }
    }
}
