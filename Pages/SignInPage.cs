using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class SignInPage(IWebDriver driver) : WebPage(driver)
    {
        #region InputFields
        public IWebElement LoginText => driver.FindElement(By.XPath("//h3[contains(text(),'Login')]"));
        public IWebElement RegisterAccountLink => driver.FindElement(By.XPath("//a[@data-test='register-link']"));
        public IWebElement ForgotPasswordLink => driver.FindElement(By.XPath("//a[@data-test='forgot-password-link']"));
        public IWebElement EmailInput => driver.FindElement(By.Id("email"));
        public IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        public IWebElement GoogleSignInButton => driver.FindElement(By.ClassName("google-sign-in-button"));
        #endregion

        #region ErrorMessages
        public IWebElement EmailErrorMessage => driver.FindElement(By.Id("email-error"));
        public IWebElement PasswordErrorMessage => driver.FindElement(By.Id("password-error"));
        #endregion

        public void GoToSignInPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "auth/login");
        }
    }
}
