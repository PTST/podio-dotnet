using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class Tag
    {
        [JsonProperty("count")]
        public long? Count { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}