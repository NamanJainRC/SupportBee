using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace SupportBee.Models.Json
{
    public class TicketJsonUrl
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }
}