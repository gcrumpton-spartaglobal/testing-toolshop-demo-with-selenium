using System;
using Reqnroll;

namespace TestingToolshopDemoWithSelenium.Steps.AddToCart
{
    [Binding]
    public class AddToCartStepDefinitions
    {
        [When("I click the add to cart button")]
        public void WhenIClickTheAddToCartButton()
        {
            throw new PendingStepException();
        }

        [Then("I receive a pop-up saying {string}")]
        public void ThenIReceiveAPop_UpSaying(string p0)
        {
            throw new PendingStepException();
        }
    }
}
