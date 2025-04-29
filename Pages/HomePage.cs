using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
