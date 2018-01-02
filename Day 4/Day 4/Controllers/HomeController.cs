using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_4.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/{id?}")]
        public ActionResult Index()
        {
            return View();
        }

       
        
    }
}