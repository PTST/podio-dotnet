using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class ConversationMessage
    {
        [JsonProperty(PropertyName = "message_id")]
        public long MessageId { get; set; }

        [JsonProperty(PropertyName = "embed_id")]
        public long? EmbedId { get; set; }

        [JsonProperty(PropertyName = "embed_file_id")]
        public long? EmbedFileId { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty(PropertyName = "embed")]
        public Embed Embed { get; set; }

        [JsonProperty(PropertyName = "embed_file")]
        public FileAttachment EmbedFile { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; set; }

        [JsonProperty(PropertyName = "files")]
        public List<FileAttachment> Files { get; set; }
    }
}