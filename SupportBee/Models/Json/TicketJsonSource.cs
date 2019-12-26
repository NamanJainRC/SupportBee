using Newtonsoft.Json;
namespace SupportBee.Models.Json
{
    public class TicketJsonSource
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}