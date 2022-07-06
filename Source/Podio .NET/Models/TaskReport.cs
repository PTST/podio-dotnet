using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class TaskReport
    {
        [JsonProperty("reassigned")]
        public TaskType Reassigned { get; set; }

        [JsonProperty("own")]
        public TaskType Own { get; set; }
    }

    public class TaskType
    {
        [JsonProperty("completed_yesterday")]
        public long CompletedYesterday { get; set; }

        [JsonProperty("upcoming")]
        public long Upcoming { get; set; }

        [JsonProperty("later")]
        public long Later { get; set; }

        [JsonProperty("tomorrow")]
        public long Tomorrow { get; set; }

        [JsonProperty("today")]
        public long Today { get; set; }

        [JsonProperty("overdue")]
        public long Overdue { get; set; }
    }
}