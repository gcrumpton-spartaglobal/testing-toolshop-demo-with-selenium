using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

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

        [When("I click on the cart icon")]
        public void WhenIClickOnTheCartIcon()
        {
            // This is necessary for both products to show up in the checkout
            Thread.Sleep(1000);

            Page.HomePage.Checkout();
        }

        [Then("I receive a pop-up saying {string}")]
        public void ThenIReceiveAPop_UpSaying(string alertText)
        {
            //Wait for the page to load
            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.CssSelector($"[role='alert'][aria-label='{alertText}']")).Displayed);

            // Find the alert element
            var alertPopUp = Driver.FindElement(By.CssSelector($"[role='alert'][aria-label='{alertText}']"));

            // Assert that the alert text is correct
            Assert.That(alertPopUp.Text, Is.EqualTo(alertText));
        }

        [Then("I should see the added items in the cart")]
        public void ThenIShouldSeeTheAddedItemsInTheCart()
        {
            Page.CheckoutPage = new CheckoutPage(Driver);

            var actualItemNames = Page.CheckoutPage.ItemNames();
            var expectedItemNames = new List<string> { "Claw Hammer", "Pliers" };

            Assert.That(actualItemNames, Is.EquivalentTo(expectedItemNames));
        }

        [Then("The price total should be ${float}")]
        public void ThenThePriceTotalShouldBe(Decimal totalPrice)
        {
            throw new PendingStepException();
        }

    }
}
