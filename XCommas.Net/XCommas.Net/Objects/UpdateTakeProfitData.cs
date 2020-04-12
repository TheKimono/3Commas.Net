using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class UpdateTakeProfitData
    {
        [JsonProperty("new_take_profit_percentage")]
        public decimal NewTakeProfitPercentage { get; set; }
    }
}
