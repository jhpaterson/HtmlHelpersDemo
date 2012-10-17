using System;
using System.Web.Mvc;

namespace HtmlHelpersDemo.Helpers
{
    public static class LabelExtensions
    {
        public static MvcHtmlString RedLabel(this HtmlHelper helper, string target, string text)
        {
            return new MvcHtmlString(
                String.Format("<label for='{0}' style='color:red'>{1}</label>", target, text));

        }
    }
}