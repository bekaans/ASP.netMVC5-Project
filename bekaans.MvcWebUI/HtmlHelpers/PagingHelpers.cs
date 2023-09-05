using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace bekaans.MvcWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html,PagingInfo paginginfo)
        {
            int totalpage =Math.Ceiling((decimal)paginginfo.TotalItems / paginginfo.ItemsPerPage;
             var StringBuilder = new StringBuilder();
            for (int i = 0; i < totalpage; i++)
            {
             var tagBuilder = new TagBuilder("a");
            tagBuilder.MergeAttribute("href", String.Format("Product/Index/?Page={0}",i));
                tagBuilder.InnerHtml = i.ToString();
                StringBuilder.Append(tagBuilder);
            }
            return MvcHtmlString.Create(StringBuilder.ToString());
        } 
    }
}