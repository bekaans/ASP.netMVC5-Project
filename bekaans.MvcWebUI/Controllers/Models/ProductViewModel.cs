using bekaans.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace bekaans.MvcWebUI
{
    public class ProductViewModel : IView
    {
        public List<Product> Products { get; set; }
        public object Paginginfo { get; set; }
    }
}