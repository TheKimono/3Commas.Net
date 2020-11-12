using System;
using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class BotEvent
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
