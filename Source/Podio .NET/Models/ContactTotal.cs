using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class ContactTotal
    {
        [JsonProperty("count")]
        public long TotalCount { get; set; }

        [JsonProperty("orgs")]
        public List<OrganizationContactTotal> Orgs { get; set; }
    }
}