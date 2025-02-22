﻿using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class SpaceMicro
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_label")]
        public string UrlLabel { get; set; }

        [JsonProperty("space_id")]
        public long SpaceId { get; set; }

        [JsonProperty("org_id")]
        public long? OrgId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}