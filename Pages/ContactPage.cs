using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class ContactPage(IWebDriver driver) : WebPage(driver)
    {
        #region InputFields
        public IWebElement FirstNameInput => driver.FindElement(By.Id("first_name"));
        public IWebElement LastNameInput => driver.FindElement(By.Id("last_name"));
        public IWebElement EmailInput => driver.FindElement(By.Id("email"));
        public IWebElement SubjectInput => driver.FindElement(By.Id("subject"));
        public IWebElement MessageInput => driver.FindElement(By.Id("message"));
        public IWebElement AttachmentInput => driver.FindElement(By.Id("attachment"));
        public IWebElement SendButton => driver.FindElement(By.ClassName("btnSubmit"));
        #endregion

        public void GoToContactPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "contact");
        }
    }
}
