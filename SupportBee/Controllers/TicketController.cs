using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft.Json;
using System.Web.Mvc;
using SupportBee.Models;
using System.Threading.Tasks;

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
        public async Task <ActionResult> ViewTickets() {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://beemvcwebticketapp.supportbee.com");

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("/users?auth_token=jMGqEzuvkQq4PAKSkoRz");
                HttpResponseMessage Res1 = await client.GetAsync("/tickets");

                var ticketList = new List<ShowTicketModel>();
                if (Res1.IsSuccessStatusCode)
                {
                    var jsonStr = Res1.Content.ReadAsStringAsync().Result;
                    var model = JsonConvert.DeserializeObject<TicketDetailModel>(jsonStr);

                   

                    var tickets = model.Tickets;

                    for (var i = 0; i < model.Total; i++)
                    {
                        var ticket = new ShowTicketModel()
                        {
                            Id = tickets[i].Id,
                            Subject = tickets[i].Subject,
                            Text = tickets[i].Content.Text,
                            RequestorName = tickets[i].Requester.Name,
                            RequestorEmail = tickets[i].Requester.Email
                        };
                        ticketList.Add(ticket);
                    }
                    
                }
                return View(MVC.Ticket.Views.ViewTickets, ticketList);
            }
            
            
        }
    }
} 