using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ProspectManager.Mvc.Extensions
{
    public static class HtmlExtensions
    {
        public static HtmlString ContactAlphabetList(this HtmlHelper helper)
        {
            var alphabet = Enumerable.Range('A', 26)
                    .Select(x => (char)x).ToList();

            var buffer = new StringBuilder();

            foreach (var letter in alphabet)
            {
                buffer.Append(helper.ActionLink(letter.ToString(), "FilteredBy", "Contacts", new { id = letter }, null));
            }

            return new HtmlString(buffer.ToString());
        }
    }
}