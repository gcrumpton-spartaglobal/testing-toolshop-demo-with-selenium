using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class ContactPage(IWebDriver driver) : WebPage(driver)
    {
        public void GoToContactPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "contact");
        }
    }
}
