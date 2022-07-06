using System.Collections.Generic;

namespace PodioAPI.Models
{
    public class PodioResponse
    {
        public dynamic Body { get; set; }
        public long Status { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string RequestUri { get; set; }
    }
}