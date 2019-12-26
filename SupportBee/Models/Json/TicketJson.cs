using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SupportBee.Models.Json
{
    public class TicketJson
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("replies_count")]
        public int RepliesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("last_activity_at")]
        public string LastActivityAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("unanswered")]
        public bool isUnanswered { get; set; }

        [JsonProperty("archived")]
        public bool isArchived { get; set; }

        [JsonProperty("spam")]
        public bool isSpam { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("source")]
        public TicketJsonSource Source { get; set; }

        [JsonProperty("cc")]
        public List<string> Cc { get; set; }

        [JsonProperty("bcc")]
        public List<string> Bcc { get; set; }

        [JsonProperty("labels")]
        public List<string> Labels { get; set; }

        [JsonProperty("requester")]
        public TicketJsonRequester Requester { get; set; }

        [JsonProperty("content")]
        public TicketJsonContent Content { get; set; }


    }
}