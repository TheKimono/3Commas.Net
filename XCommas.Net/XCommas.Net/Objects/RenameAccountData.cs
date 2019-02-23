using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net.Objects
{
    public class RenameAccountData
    {
        [JsonProperty("name")]
        public string NewName { get; set; }
    }
}
