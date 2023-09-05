using bekaans.Entities;
using bekaans.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bekaans.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryservice;

        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }

        public PartialViewResult List(int category =0)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(_categoryservice.GetAll());
        }
    }
}