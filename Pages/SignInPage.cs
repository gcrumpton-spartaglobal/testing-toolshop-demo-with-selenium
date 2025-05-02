using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class SignInPage(IWebDriver driver) : WebPage(driver)
    {
        public void GoToSignInPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "auth/login");
        }
    }
}
