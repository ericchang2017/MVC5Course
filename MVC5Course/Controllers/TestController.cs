using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC5Course.Models;

namespace MVC5Course.Controllers
{
    public class TestController : Controller
    {
        FabricsEntities db = new FabricsEntities();

        // GET: Test
        public ActionResult Index()
        {
            var data = from p in db.Product
                       select p;
            return View(data.Take(10));
        }
    }
}