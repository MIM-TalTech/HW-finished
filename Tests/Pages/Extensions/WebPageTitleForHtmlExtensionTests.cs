using System.Collections.Generic;
using HW4.Aids;
using HW4.Facade.Quantity;
using HW4.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4.Tests.Pages.Extensions
{
    [TestClass]
    public class WebPageTitleForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(WebPageTitleForHtmlExtension);

        [TestMethod]
        public void WebPageTitleForTest()
        {
            var obj = new htmlHelperMock<UnitView>().WebPageTitleFor(GetRandom.String());
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }

        [TestMethod]
        public void HtmlStringsTest()
        {
            var expected = new List<string> { "<h1>", GetRandom.String(), "</h1>" };
            var actual = WebPageTitleForHtmlExtension.htmlStrings(expected[1]);
            TestHtml.Strings(actual, expected);
        }
    }
}
