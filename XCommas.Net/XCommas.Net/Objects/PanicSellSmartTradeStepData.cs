using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class PanicSellSmartTradeStepData
    {
        [JsonProperty("step_id")]
        public int StepId { get; set; }
    }
}
