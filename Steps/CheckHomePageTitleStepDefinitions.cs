using System;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;
using TestingToolshopDemoWithSelenium.Steps.Navigation;

namespace TestingToolshopDemoWithSelenium.Steps
{
    [Binding]
    public class CheckHomePageTitleStepDefinitions : BaseStepDefinitions
    {
        public string PageTitle { get; set; }

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
