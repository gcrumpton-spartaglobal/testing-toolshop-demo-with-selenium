using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class ContactPage(IWebDriver driver) : WebPage(driver)
    {
        #region InputFields
        public IWebElement FirstNameInput => driver.FindElement(By.Id("first_name"));
        public IWebElement LastNameInput => driver.FindElement(By.Id("last_name"));
        #endregion

        public void GoToContactPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "contact");
        }
    }
}
