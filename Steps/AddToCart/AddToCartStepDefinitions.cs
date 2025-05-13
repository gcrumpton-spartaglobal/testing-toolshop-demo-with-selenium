using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace TestingToolshopDemoWithSelenium.Steps.AddToCart
{
    [Binding]
    public class AddToCartStepDefinitions : BaseStepDefinitions
    {
        [When("I click the add to cart button")]
        public void WhenIClickTheAddToCartButton()
        {
            //Wait for the page to load
            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(d => d.FindElement(By.CssSelector("#btn-add-to-cart")).Displayed);

            // Find the add to cart button
            var addToCartButton = Driver.FindElement(By.CssSelector("#btn-add-to-cart"));

            // Click the add to cart button
            addToCartButton.Click();
        }

        [Then("I receive a pop-up saying {string}")]
        public void ThenIReceiveAPop_UpSaying(string p0)
        {
            throw new PendingStepException();
        }
    }
}
