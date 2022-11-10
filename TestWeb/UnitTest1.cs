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
        private IWebDriver driver { get; set; }

        [TestMethod]
        [TestCategory("Yahoo")]
        public void TestYahoo()
        {
            // var driver = GetChromeDriver();
            //     driver.Navigate().GoToUrl("https://www.yahoo.com");

            driver = GetChromeDriver();
            var yahooHomePage = new YahooHomePage(driver);
            yahooHomePage.GoTo();
            Assert.IsTrue(yahooHomePage.IsVisible);
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }

    public class YahooHomePage
    {
        public YahooHomePage(object driver)
        {
            throw new System.NotImplementedException();
        }

        public bool IsVisible { get; set; }

        public void GoTo()
        {
            throw new System.NotImplementedException();
        }
    }
}