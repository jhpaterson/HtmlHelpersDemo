using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.WebPages;

namespace HtmlHelpersDemo.Helpers
{
    public static class DelegateExtensions
    {
        public static HelperResult List<T>(this IEnumerable<T> items,
            Func<T, HelperResult> template)
        {
            return new HelperResult(writer =>
            {
                foreach (var item in items)
                {
                    template(item).WriteTo(writer);
                }
            });
        }
    }
}