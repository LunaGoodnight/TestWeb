using OpenQA.Selenium;

namespace TestWeb
{
    public class YahooHomePage
    {
        private IWebDriver _driver;

        public YahooHomePage(IWebDriver driver)
        {
            _driver = driver;
    
        }

        public bool IsVisible => _driver.Title.Contains("Yahoo");

        public void GoTo()
        {
           _driver.Navigate().GoToUrl("https://us.yahoo.com/");
           
        }
    }
}