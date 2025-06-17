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

        public List<string> ItemNames()
        {
            var items = driver.FindElements(By.CssSelector("span[data-test='product-title']"))
                .Select(e => e.Text.Trim())
                .ToList();

            List<string> itemNames = new List<string>();

            foreach (var item in items)
            {
                //var titleElement = item.FindElement(By.ClassName("product-title"));
                itemNames.Add(item);
            }

            return itemNames;
        }
    }
}
