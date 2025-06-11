using Reqnroll;

namespace TestingToolshopDemoWithSelenium.Steps.SignIn
{
    [Binding]
    public class SignInStepDefinitions : BaseStepDefinitions
    {
        [When("I fill out the sign in form with the following information:")]
        public void WhenIFillOutTheSignInFormWithTheFollowingInformation(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Then("I am taken to the admin dashboard")]
        public void ThenIAmTakenToTheAdminDashboard()
        {
            throw new PendingStepException();
        }
    }
}
