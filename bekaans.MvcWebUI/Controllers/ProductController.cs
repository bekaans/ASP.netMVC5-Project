using bekaans.BLL.Concrete;
using bekaans.DataAccessLayer.Concrete.EntityFramework;
using bekaans.Entities;
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


        public int pageSize = 5;
        public ActionResult Index(int page=1,int category=1)
        {
            List<Product> products = _iproductservice.GetAll().Where(p=>p.CategoryID==category).ToList();
            return View(new ProductViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(5).ToList(),
                Paginginfo = new PagingInfo
                {
                    ItemsPerPage = pageSize,
                    TotalItems = products.Count,
                    CurrentPage = page
                }
            }) ;
        }
    }
}