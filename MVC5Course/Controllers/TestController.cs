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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product data)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(data);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult Edit(int id)
        {
            var item = db.Product.Find(id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product data)
        {
            if(ModelState.IsValid)
            {
                var item = db.Product.Find(id);

                item.ProductName = data.ProductName;
                item.Price = data.Price;
                item.Active = data.Active;
                item.Stock = data.Stock;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult Details(int id)
        {
            return View(db.Product.Find(id));
        }

        public ActionResult Delete(int id)
        {
            var item = db.Product.Find(id);

            db.OrderLine.RemoveRange(item.OrderLine.ToList());
            db.Product.Remove(item);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}