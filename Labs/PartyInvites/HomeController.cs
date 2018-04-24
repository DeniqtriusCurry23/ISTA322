using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        { 

            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour< 12)
              timeOfDay = "Good Morning"; 
            else if (hour< 18)
             timeOfDay = "Good Afternoon";
            else
                timeOfDay = "Good Evening";
            ViewBag.Greeting = timeOfDay; 
            return View();
        }
    }
}