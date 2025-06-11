using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps.SignIn
{
    [Binding]
    public class SignInStepDefinitions : BaseStepDefinitions
    {
        private SignInForm signInForm;

        [When("I fill out the sign in form with the following information:")]
        public void WhenIFillOutTheSignInFormWithTheFollowingInformation(DataTable dataTable)
        {
            signInForm = dataTable.CreateInstance<SignInForm>();

            // Fill out the form with the account information
            Page.SignInPage.EmailInput.SendKeys(signInForm.Email);
            Page.SignInPage.PasswordInput.SendKeys(signInForm.Password);
        }

        [Then("I am taken to the admin dashboard")]
        public void ThenIAmTakenToTheAdminDashboard()
        {
            throw new PendingStepException();
        }
    }
}
