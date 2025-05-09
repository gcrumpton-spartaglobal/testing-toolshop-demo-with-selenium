using System;
using Reqnroll;

namespace TestingToolshopDemoWithSelenium.Steps
{
    [Binding]
    public class CheckHomePageTitleStepDefinitions
    {
        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            throw new PendingStepException();
        }

        [When("I check the title")]
        public void WhenICheckTheTitle()
        {
            throw new PendingStepException();
        }

        [Then("the title should be {string}")]
        public void ThenTheTitleShouldBe(string p0)
        {
            throw new PendingStepException();
        }
    }
}
