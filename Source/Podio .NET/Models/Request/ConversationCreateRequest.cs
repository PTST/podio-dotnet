using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioAPI.Models.Request
{
    public class ConversationCreateRequest
    {
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("file_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> FileIds { get; set; }

        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Participants { get; set; }

        [JsonProperty("embed_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EmbedId { get; set; }

        [JsonProperty("embed_url", NullValueHandling = NullValueHandling.Ignore)]
        public string EmbedUrl { get; set; }
    }
}