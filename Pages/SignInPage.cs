using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class SignInPage(IWebDriver driver) : WebPage(driver)
    {
        public IWebElement LoginText => driver.FindElement(By.XPath("//h3[contains(text(),'Login')]"));
        public IWebElement RegisterAccountLink => driver.FindElement(By.XPath("//a[@data-test='register-link']"));
        public IWebElement ForgotPasswordLink => driver.FindElement(By.XPath("//a[@data-test='forgot-password-link']"));

        public void GoToSignInPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "auth/login");
        }
    }
}
