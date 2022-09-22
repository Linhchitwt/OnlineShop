using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Grid.Controllers
{
    public class HomeController : Controller
    {
        // GET: Grid/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}