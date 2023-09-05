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

        public CartController(IProductService productservice)
        {
            _productservice = productservice;
        }

        public ActionResult AddToCart(int productid)
        {
            Product product  = _productservice.Get(productid);
            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddToCart(product, 1);
            return View("Index");
        }
    }
}