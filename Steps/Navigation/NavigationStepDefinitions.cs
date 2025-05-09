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
        public static HomePage HomePage { get; set; }

        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            HomePage = new HomePage(Driver);

            HomePage.GoToHomePage();
        }
    }
}
