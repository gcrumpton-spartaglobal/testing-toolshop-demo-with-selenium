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
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.CssSelector("#btn-add-to-cart")).Displayed);

            // Find the add to cart button
            var addToCartButton = Driver.FindElement(By.CssSelector("#btn-add-to-cart"));

            // Click the add to cart button
            addToCartButton.Click();
        }

        [Then("I receive a pop-up saying {string}")]
        public void ThenIReceiveAPop_UpSaying(string alertText)
        {
            //Wait for the page to load
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.CssSelector($"[role='alert'][aria-label='{alertText}']")).Displayed);

            // Find the alert element
            var alertPopUp = Driver.FindElement(By.CssSelector($"[role='alert'][aria-label='{alertText}']"));

            // Assert that the alert text is correct
            Assert.That(alertPopUp.Text, Is.EqualTo(alertText));
        }
    }
}
