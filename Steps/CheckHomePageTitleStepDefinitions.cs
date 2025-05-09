using System;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps
{
    [Binding]
    public class CheckHomePageTitleStepDefinitions : BaseStepDefinitions
    {
        public HomePage Page { get; set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            SetUp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TearDown();
        }

        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Page = new HomePage(Driver);

            Page.GoToHomePage();
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
