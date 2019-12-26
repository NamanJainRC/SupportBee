using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SupportBee.Models.Json;

namespace SupportBee.Models
{
    public class TicketDetailModel
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("tickets")]
        public List<TicketJson> Tickets { get; set; }

    }
}