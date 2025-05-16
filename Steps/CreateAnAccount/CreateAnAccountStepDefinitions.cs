using System;
using Reqnroll;

namespace TestingToolshopDemoWithSelenium.Steps.CreateAnAccount
{
    [Binding]
    public class CreateAnAccountStepDefinitions
    {
        [When("I click {string}")]
        public void WhenIClick(string p0)
        {
            throw new PendingStepException();
        }

        [When("I fill out the form with the following information:")]
        public void WhenIFillOutTheFormWithTheFollowingInformation(DataTable dataTable)
        {
            var accounts = dataTable.CreateSet<Account>();
        }

        [When("I click on the {string} button")]
        public void WhenIClickOnTheButton(string register)
        {
            throw new PendingStepException();
        }
    }
}
