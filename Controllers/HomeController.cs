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
            //var Productsslist=Db.ProductDetails.Find(12);
            Session.Add("e1", Productsslist);
            return View(Productsslist);

        }

      
        public ActionResult GoToCartView(int? Id)
        {
            ProductDetail GetProduct = Db.ProductDetails.SingleOrDefault(a => a.ProductID == Id);
            int ProductIDD = GetProduct.ProductID;
            string ProductName = GetProduct.ProductName;
            int ProductPrice = GetProduct.ProductPrice;
            ProductDetail product = new ProductDetail()
            {
                ProductID = ProductIDD,
                ProductName = ProductName,
                ProductPrice = ProductPrice
            };

            Session["Data"] = product;
            return View();
        }

        public ActionResult CalculateTotal(ProductOrder Order)
        {
            int Delievery = 30;
            ProductDetail GetProduct = Db.ProductDetails.SingleOrDefault(a => a.ProductID == Order.ProductID);
            int ProductPrice =(GetProduct.ProductPrice != null)?GetProduct.ProductPrice : 0;
            int Quantity = Order.ProductQuantity;
            ProductOrder ProductsOrder = new ProductOrder()
            {
                ProductID = GetProduct.ProductID,
                ProductPrice = GetProduct.ProductPrice,
                ProductQuantity = Order.ProductQuantity
            };
            int Calculate = ProductPrice * Quantity + Delievery;
            Session["ClientOrder"] = ProductsOrder;
            Session["FinalCheckout"] = Calculate;
            return View();
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }

}