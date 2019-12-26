using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SupportBee.Models.Json
{
    public class TicketJsonPicture
    {
        [JsonProperty("thumb20")]
        public string Thumb20 { get; set; }

        [JsonProperty("thumb24")]
        public string Thumb24 { get; set; }

        [JsonProperty("thumb32")]
        public string Thumb32 { get; set; }

        [JsonProperty("thumb48")]
        public string Thumb48 { get; set; }

        [JsonProperty("thumb64")]
        public string Thumb64 { get; set; }

        [JsonProperty("thumb128")]
        public string Thumb128 { get; set; }
    }

}