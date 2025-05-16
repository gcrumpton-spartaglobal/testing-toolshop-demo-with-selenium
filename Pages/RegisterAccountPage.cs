using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class RegisterAccountPage(IWebDriver driver) : WebPage(driver)
    {
        public IWebElement FirstNameInput => driver.FindElement(By.Id("first_name"));
        public IWebElement LastNameInput => driver.FindElement(By.Id("last_name"));
    }
}
