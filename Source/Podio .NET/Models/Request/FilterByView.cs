using Newtonsoft.Json;

namespace PodioAPI.Models.Request
{
    public class FilterByView
    {
        /// <summary>
        ///     The maximum number of items to return, defaults to 30
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long Limit { get; set; }

        /// <summary>
        ///     The offset longo the returned items, defaults to 0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long Offset { get; set; }

        /// <summary>
        ///     True if the view should be remembered, false otherwise
        /// </summary>
        [JsonProperty("remember", NullValueHandling = NullValueHandling.Ignore)]
        public bool Remember { get; set; }
    }
}