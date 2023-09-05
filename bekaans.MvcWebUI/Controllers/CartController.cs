using bekaans.Entities;
using bekaans.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bekaans.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        IProductService _productservice;
        public ActionResult Index()
        {
            var cart = (Cart)Session["cart"];
            return View(cart);
        }
        public CartController(IProductService productservice)
        {
            _productservice = productservice;
        }

        public RedirectToRouteResult AddToCart(int productid)
        {
            Product product  = _productservice.Get(productid);
            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddToCart(product, 1);
            return RedirectToAction("Index",cart);
        }
        public RedirectToRouteResult RemoveFromCart(int productid) 
        {
            Product product = _productservice.Get(productid);
            var cart = (Cart)Session["cart"];
            cart.RemoveFromCart(product);
            return RedirectToAction("Index",cart);
        }
        [HttpGet]
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                return View("Complated");
            }
            else
            {
                return View(shippingDetails);
            }
           
        }
    }
}