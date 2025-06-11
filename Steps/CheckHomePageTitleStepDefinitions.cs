using System;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps
{
    [Binding]
    public class CheckHomePageTitleStepDefinitions : BaseStepDefinitions
    {
        public string PageTitle { get; set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Set browser from environment variable, tag, or default
            Browser = Environment.GetEnvironmentVariable("TEST_BROWSER") ?? "chrome";
            SetUp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TearDown();
        }

        [When("I check the title")]
        public void WhenICheckTheTitle()
        {
            PageTitle = Page.HomePage.PageTitle;
        }

        [Then("the title should be {string}")]
        public void ThenTheTitleShouldBe(string title)
        {
            Assert.That(PageTitle, Is.EqualTo(title));
        }
    }
}
