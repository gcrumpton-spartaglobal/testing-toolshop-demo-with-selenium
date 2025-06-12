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
            // Explicit wait for the account dashboard to load
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Driver.FindElement(By.XPath("//h1[contains(text(), 'My account')]")).Displayed);

            Assert.That(Driver.FindElement(By.XPath("//h1[contains(text(), 'My account')]")).Displayed, Is.True);
        }

        [Then("I receive an error message for the email and password fields")]
        public void ThenIReceiveAnErrorMessageForTheEmailAndPasswordFields()
        {
            // Explicit wait for the error messages to be displayed
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Page.SignInPage.EmailErrorMessage.Displayed && Page.SignInPage.PasswordErrorMessage.Displayed);

            Assert.Multiple(() =>
            {
                Assert.That(Page.SignInPage.EmailErrorMessage.Displayed, Is.True, "Email error message is not displayed");
                Assert.That(Page.SignInPage.PasswordErrorMessage.Displayed, Is.True, "Password error message is not displayed");
            });
        }
    }
}
