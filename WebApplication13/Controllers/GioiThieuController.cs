using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers.Admin
{
    public class GioiThieuController : Controller
    {
        // GET: GioiThieu
        public ActionResult Index()
        {

            var s1 = Directory.GetCurrentDirectory();
            var s = Server.MapPath("../Helper/Email/Templates");

            ViewBag.s = s1;
            return View();
            //test
        }
    }
}