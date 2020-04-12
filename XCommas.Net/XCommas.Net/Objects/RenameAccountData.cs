using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class RenameAccountData
    {
        [JsonProperty("name")]
        public string NewName { get; set; }
    }
}
