using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net.Objects
{
    public class UpdateMaxSafetyOrderData
    {
        [JsonProperty("max_safety_orders")]
        public int MaxSafetyOrders { get; set; }
    }
}
