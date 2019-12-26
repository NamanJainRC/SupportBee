using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SupportBee.Models.Json
{
    public class TicketJsonContent
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("attachments")]
        public List<TicketJsonAttachment> Attachment { get; set; }
    }

}