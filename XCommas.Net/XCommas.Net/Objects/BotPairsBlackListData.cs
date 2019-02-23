using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net.Objects
{
    public class BotPairsBlackListData
    {
        [JsonProperty("pairs")]
        public string[] Pairs { get; set; }
    }
}
