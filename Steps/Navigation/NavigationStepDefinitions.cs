using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps.Navigation
{
    [Binding]
    public class NavigationStepDefinitions : BaseStepDefinitions
    {
        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Page.HomePage = new HomePage(Driver);

            Page.HomePage.GoToHomePage();
        }

        [When("I scroll to the {string} product")]
        public void WhenIScrollToTheProduct(string p0)
        {
            //Wait for the page to load
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath("//h5[@data-test='product-name' and contains(text(), 'Claw Hammer')]")).Displayed);

            // Find the element you want to scroll to
            IWebElement productCard = Driver.FindElement(By.XPath("//h5[@data-test='product-name' and contains(text(), 'Claw Hammer')]"));

            // Scroll to the element
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", productCard);
        }

        [When("I click on the {string} card")]
        public void WhenIClickOnTheCard(string p0)
        {
            throw new PendingStepException();
        }

        [When("I am taken to the {string} product page")]
        public void WhenIAmTakenToTheProductPage(string p0)
        {
            throw new PendingStepException();
        }

    }
}
