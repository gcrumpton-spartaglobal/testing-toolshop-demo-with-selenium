using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps.Navigation
{
    [Binding]
    public class NavigationStepDefinitions : BaseStepDefinitions
    {
        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Page.HomePage = new HomePage(Driver);

            Page.HomePage.GoToHomePage();
        }

        [When("I scroll to the {string} product")]
        public void WhenIScrollToTheProduct(string p0)
        {
            throw new PendingStepException();
        }

        [When("I click on the {string} card")]
        public void WhenIClickOnTheCard(string p0)
        {
            throw new PendingStepException();
        }

        [When("I am taken to the {string} product page")]
        public void WhenIAmTakenToTheProductPage(string p0)
        {
            throw new PendingStepException();
        }

    }
}
