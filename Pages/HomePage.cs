using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        IWebElement searchBox => driver.FindElement(By.Id("search-query"));

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/");
        }
    }
}
