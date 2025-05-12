using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class CheckoutPage(IWebDriver driver) : WebPage(driver)
    {
        public IWebElement CheckoutTotal => driver.FindElement(By.XPath("//td[contains(text(),'$')]"));

        public void GoToCheckoutPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "checkout");
        }
    }
}
