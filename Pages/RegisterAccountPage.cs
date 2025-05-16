using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class RegisterAccountPage(IWebDriver driver) : WebPage(driver)
    {
        public IWebElement FirstNameInput => driver.FindElement(By.Id("first_name"));
    }
}
