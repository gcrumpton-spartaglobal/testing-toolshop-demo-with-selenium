using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private const string BaseUrl = "https://practicesoftwaretesting.com/";

        IWebElement SearchBox => _driver.FindElement(By.Id("search-query"));
        public string PageTitle => _driver.Title;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToHomePage()
        {
            _driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Search(string searchText)
        {
            SearchBox.SendKeys(searchText);
            SearchBox.SendKeys(Keys.Enter);
        }
    }
}
