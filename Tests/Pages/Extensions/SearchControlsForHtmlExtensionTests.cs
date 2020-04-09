using System.Collections.Generic;
using HW4.Facade.Quantity;
using HW4.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Pages.Extensions
{
    [TestClass]
    public class SearchControlsForHtmlExtensionTests : BaseTests
    {
        private const string filter = "filter";
        private const string linkToFullList = "url";
        private const string text = "text";

        [TestInitialize] public virtual void TestInitialize() => type = typeof(SearchControlsForHtmlExtension);

        [TestMethod]
        public void SearchControlsForTest()
        {
            var obj = new htmlHelperMock<UnitView>().SearchControlsFor(filter, linkToFullList, text);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }

        [TestMethod]
        public void HtmlStringsTest()
        {
            var expected = new List<string> {
                "<form asp-action=\"./Index\" method=\"get\">",
                "<div class=\"form-inline col-md-6\">",
                "Find by:",
                "&nbsp;",
                $"<input class=\"form-control\" type=\"text\" name=\"SearchString\" value=\"{filter}\" />",
                "&nbsp;",
                "<input type=\"submit\" value=\"Search\" class=\"btn btn-default\" />",
                "&nbsp;",
                $"<a href=\"{linkToFullList}\">{text}</a>",
                "</div>",
                "</form>"
            };
            var actual = SearchControlsForHtmlExtension.htmlStrings(filter, linkToFullList, text);
            TestHtml.Strings(actual, expected);
        }
    }
}
