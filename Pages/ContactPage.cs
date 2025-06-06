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

        #region ErrorMessages
        public IWebElement FirstNameErrorMessage => driver.FindElement(By.Id("first_name_alert"));
        public IWebElement LastNameErrorMessage => driver.FindElement(By.Id("last_name_alert"));
        public IWebElement EmailErrorMessage => driver.FindElement(By.Id("email_alert"));
        public IWebElement SubjectErrorMessage => driver.FindElement(By.Id("subject_alert"));
        public IWebElement MessageIsRequiredErrorMessage => driver.FindElement(By.XPath("//div[contains(text(), 'Message is required')]"));
        public IWebElement MessageIsTooShortErrorMessage => driver.FindElement(By.XPath("//div[contains(text(), 'Message must be minimal 50 characters')]"));
        public IWebElement MessageIsTooLongErrorMessage => driver.FindElement(By.XPath("//div[contains(text(), 'The message field must not be greater than 250')]"));
        #endregion

        public void GoToContactPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "contact");
        }
    }
}
