using System;
using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class Batch
    {
        [JsonProperty("batch_id")]
        public long? BatchId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plugin")]
        public string Plugin { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("completed")]
        public long? Completed { get; set; }

        [JsonProperty("skipped")]
        public long? Skipped { get; set; }

        [JsonProperty("failed")]
        public long? Failed { get; set; }

        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

        [JsonProperty("started_on")]
        public DateTime? StartedOn { get; set; }

        [JsonProperty("ended_on")]
        public DateTime? EndedOn { get; set; }

        [JsonProperty("file")]
        public FileAttachment File { get; set; }

        [JsonProperty("app")]
        public Application App { get; set; }

        [JsonProperty("space")]
        public Space Space { get; set; }
    }
}