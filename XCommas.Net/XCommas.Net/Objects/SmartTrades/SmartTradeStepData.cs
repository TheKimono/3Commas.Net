using Newtonsoft.Json;

namespace XCommas.Net.Objects.SmartTrades
{
    public class SmartTradeStepData
    {
        [JsonProperty("cancelable")]
        public bool Cancelable { get; set; }
        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }
    }
}