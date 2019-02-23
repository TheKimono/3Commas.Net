using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net.Objects
{
    public class PanicSellSmartTradeStepData
    {
        [JsonProperty("step_id")]
        public int StepId { get; set; }
    }
}
