using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketApp_usingEF.Controllers
{
    public class HomeController : Controller
    {
        TicketEntities1 db = new TicketEntities1();

        [Route("")]
        [Route("Home")]
        [Route("tickets")]
        [Route("Home/tickets")]
        //Home
        //tickets
        // GET: Home
        public ActionResult Index()
        {
            List<Ticket> TicketList = (from x in db.Tickets
                                       select x).ToList();

            return View(TicketList);
        }

        [HttpGet]
        [Route("add-ticket")]
        [Route("Home/add-ticket")]
        //add-ticket
        //Home/add-ticket
        public ActionResult AddTicket()
        {
            return View();
        }

        [HttpPost]
        [Route("add-ticket")]
        [Route("Home/add-ticket")]
        public ActionResult AddTicket(Ticket myTicket)
        {
            //TicketList.Add(myTicket);

            if ("Open".Equals(myTicket.Status)) myTicket.IsClosed = "NO";
            else myTicket.IsClosed = "YES";

            db.Tickets.Add(myTicket);
            db.SaveChanges();

            return View("ThankYou", myTicket);
        }
    }
}