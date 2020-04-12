using Newtonsoft.Json;

namespace XCommas.Net.Objects
{
    public class AccountCreateData
    {
        [JsonProperty("type")]
        public string MarketName { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
        [JsonProperty("secret")]
        public string Secret { get; set; }
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
        [JsonProperty("passphrase")]
        public string PassPhrase { get; set; }
    }
}
