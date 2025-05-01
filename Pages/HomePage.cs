using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        IWebElement searchBox => _driver.FindElement(By.Id("search-query"));

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void GoToHomePage()
        {
            _driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/");
        }

        public void Search(string searchText)
        {
            searchBox.SendKeys(searchText);
            searchBox.SendKeys(Keys.Enter);
        }
    }
}
