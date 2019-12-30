using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SupportBee.Models
{
    public class CreateTicketModel
    {

        public string Subject { get; set; }

        public string Text { get; set; }

        [DisplayName("Requestor Name") ]
        public string RequestorName { get; set; }

        [DisplayName("Requestor Email")]
        public string RequestorEmail { get; set; }
    }
}