using Product_Cart_Shop_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_Cart_Shop_Task.Controllers
{
    public class HomeController : Controller
    {
        Model1 Db;
        public HomeController()
        {
            Db = new Model1();
        }
        public ActionResult Index()
        {
            var Productsslist = Db.ProductDetails.ToList();
            return View(Productsslist);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GoToCartView(int? ProductId)
        {

            var GetProduct = Db.ProductDetails.SingleOrDefault(a => a.ProductID == ProductId);

            ProductDetail product = new ProductDetail()
            {
                ProductName = "Dress",
                ProductPrice = 50
            };
            Session["Data"] = product;
            return View();
        }
        //public ActionResult CalculateTotal()
        //{
        //    var calculate= 30 + 50 * 3;
        //    return View(calculate);
        //}
    }

}