using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class AppMarketShareInstall
    {
        [JsonProperty("app_id")]
        public long AppId { get; set; }

        [JsonProperty("child_app_ids")]
        public List<long> ChildAppIds { get; set; }
    }
}