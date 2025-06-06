using System;
using Reqnroll;

namespace TestingToolshopDemoWithSelenium.Steps.SendContactForm
{
    [Binding]
    public class SendContactFormStepDefinitions
    {
        [When("I fill out the contact form with the following information:")]
        public void WhenIFillOutTheContactFormWithTheFollowingInformation(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Then("I receive a confirmation message")]
        public void ThenIReceiveAConfirmationMessage()
        {
            throw new PendingStepException();
        }
    }
}
