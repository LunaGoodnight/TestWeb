using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestWeb
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver Driver { get; set; }

        [TestMethod]
        [TestCategory("Yahoo")]
        public void TestYahoo()
        {

            Driver = GetChromeDriver();
            var yahooHomePage = new YahooHomePage(Driver);
            yahooHomePage.GoTo();
            Assert.IsTrue(yahooHomePage.IsVisible);
            // Opens a new tab and switches to new tab
            Driver.SwitchTo().NewWindow(WindowType.Tab);
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}