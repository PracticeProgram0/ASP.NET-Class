using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template_Html
{
    public static class Myhelper
    {
        public static IHtmlString Button(this HtmlHelper helper,string value)
        {
            TagBuilder tag = new TagBuilder("input");
            tag.Attributes.Add("type","Submit");
            tag.Attributes.Add("value",value);


            return new MvcHtmlString(tag.ToString());
        }

        public static IHtmlString image(this HtmlHelper helper,string src,string alt)
        {

            return new MvcHtmlString ($"<img src ='{src}' alt ='{alt}'");
        }
    }
}