using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class SignInPage(IWebDriver driver) : WebPage(driver)
    {
        public IWebElement LoginText => driver.FindElement(By.XPath("//h3[contains(text(),'Login')]"));

        public void GoToSignInPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "auth/login");
        }
    }
}
