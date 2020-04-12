using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class UpdateMaxSafetyOrderData
    {
        [JsonProperty("max_safety_orders")]
        public int MaxSafetyOrders { get; set; }
    }
}
