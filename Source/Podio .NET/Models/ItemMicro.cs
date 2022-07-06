using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class ItemMicro
    {
        [JsonProperty("app_item_id")]
        public long AppItemId { get; set; }

        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }
    }
}