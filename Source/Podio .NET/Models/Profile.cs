using System;
using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class Profile
    {
        [JsonProperty("profile_id")]
        public long ProfileId { get; set; }

        [JsonProperty("avatar")]
        public long? Avatar { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("last_seen_on")]
        public DateTime? LastSeenOn { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("org_id")]
        public long? OrgId { get; set; }

        [JsonProperty("space_id")]
        public long? SpaceId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user_id")]
        public long? UserId { get; set; }
    }
}