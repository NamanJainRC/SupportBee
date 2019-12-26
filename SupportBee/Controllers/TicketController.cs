using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;
using SupportBee.Models;

namespace SupportBee.Controllers
{
    public partial class TicketController : Controller
    {
        public virtual ActionResult CreateTicket()
        {
            var ticket = new CreateTicketModel();
            return View(MVC.Ticket.Views.CreateTicket,ticket);
        }


        //[ValidateAntiForgeryToken]
        //[HttpPost]
        //public virtual ActionResult CreateTicket(CreateTicketMOdel ticket)
        //{

        //}
        public virtual ActionResult ViewTickets(string jsonstr) {

            var model = JsonConvert.DeserializeObject<TicketDetailModel>(jsonstr);


            return PartialView(MVC.Ticket.Views._ViewTickets,model);
        }
    }
}