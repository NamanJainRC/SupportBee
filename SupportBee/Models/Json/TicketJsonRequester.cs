using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace SupportBee.Models.Json
{
    public class TicketJsonRequester
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("agent")]
        public bool isAgent { get; set; }

        [JsonProperty("picture")]
        public TicketJsonPicture Picture { get; set; }
    }

}