using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            // Explicit wait for the admin dashboard to load
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Driver.FindElement(By.XPath("//h1[contains(text(), 'Sales over the years')]")).Displayed);

            Assert.That(Driver.FindElement(By.XPath("//h1[contains(text(), 'Sales over the years')]")).Displayed, Is.True);
        }

        [Then("I am taken to the account dashboard")]
        public void ThenIAmTakenToTheAccountDashboard()
        {
            throw new PendingStepException();
        }

    }
}
