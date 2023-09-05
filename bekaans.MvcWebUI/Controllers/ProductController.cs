using bekaans.BLL.Concrete;
using bekaans.DataAccessLayer.Concrete.EntityFramework;
using bekaans.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bekaans.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _iproductservice;

        public ProductController(IProductService iproductservice)
        {
            _iproductservice = iproductservice;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_iproductservice.GetAll());
        }
    }
}