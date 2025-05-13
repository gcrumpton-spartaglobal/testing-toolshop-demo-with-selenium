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
        public IWebElement ProductCard { get; set; }

        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Page.HomePage = new HomePage(Driver);

            Page.HomePage.GoToHomePage();
        }

        [When("I scroll to the {string} product")]
        public void WhenIScrollToTheProduct(string productName)
        {
            //Wait for the page to load
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath($"//h5[@data-test='product-name' and contains(text(), '{productName}')]")).Displayed);

            // Find the element you want to scroll to
            ProductCard = Driver.FindElement(By.XPath($"//h5[@data-test='product-name' and contains(text(), '{productName}')]"));

            // Scroll to the element
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", ProductCard);
        }

        [When("I click on the {string} card")]
        public void WhenIClickOnTheCard(string productName)
        {
            // Click the element
            ProductCard.Click();
        }
    }
}
