using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class Presence
    {
        [JsonProperty("ref_id")]
        public long? RefId { get; set; }

        [JsonProperty("ref_type")]
        public string RefType { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("user_id")]
        public long? UserId { get; set; }
    }
}