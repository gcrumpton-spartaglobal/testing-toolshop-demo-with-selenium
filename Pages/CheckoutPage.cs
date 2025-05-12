using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class CheckoutPage(IWebDriver driver) : WebPage(driver)
    {
        public void GoToCheckoutPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "checkout");
        }
    }
}
