using System;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps.CreateAnAccount
{
    [Binding]
    public class CreateAnAccountStepDefinitions : BaseStepDefinitions
    {
        private Account account;

        [When("I click {string}")]
        public void WhenIClick(string p0)
        {
            Page.SignInPage = new SignInPage(Driver);

            Thread.Sleep(5000);

            Page.SignInPage.RegisterAccountLink.Click();
        }

        [When("I fill out the form with the following information:")]
        public void WhenIFillOutTheFormWithTheFollowingInformation(DataTable dataTable)
        {
            account = dataTable.CreateInstance<Account>();
            var registerAccountPage = new RegisterAccountPage(Driver);

            // Fill out the form with the account information
            registerAccountPage.FirstNameInput.SendKeys(account.FirstName);
            registerAccountPage.LastNameInput.SendKeys(account.LastName);
            registerAccountPage.DateOfBirthInput.SendKeys(account.DateOfBirth);
            registerAccountPage.StreetInput.SendKeys(account.Street);
            registerAccountPage.PostalCodeInput.SendKeys(account.PostalCode);
            registerAccountPage.CityInput.SendKeys(account.City);
            registerAccountPage.StateInput.SendKeys(account.State);
            registerAccountPage.CountryInput.SendKeys(account.Country);
            registerAccountPage.PhoneInput.SendKeys(account.Phone);
            registerAccountPage.EmailInput.SendKeys(account.Email);
            registerAccountPage.PasswordInput.SendKeys(account.Password);
        }

        [When("I click on the {string} button")]
        public void WhenIClickOnTheButton(string buttonText)
        {
            if (buttonText == "Register")
            {
                Page.RegisterAccountPage = new RegisterAccountPage(Driver);

                // Click the register button
                Page.RegisterAccountPage.RegisterButton.Click();
            }

            else if (buttonText == "Send")
            {
                Page.ContactPage = new ContactPage(Driver);

                // Click the send button
                Page.ContactPage.SendButton.Click();
            }
        }

        [Then("I receive an error message for each field")]
        public void ThenIReceiveAnErrorMessageForEachField()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Page.RegisterAccountPage.FirstNameErrorMessage.Displayed, Is.True, "First Name error message is not displayed");
                Assert.That(Page.RegisterAccountPage.LastNameErrorMessage.Displayed, Is.True, "Last Name error message is not displayed");
                Assert.That(Page.RegisterAccountPage.DateOfBirthErrorMessage.Displayed, Is.True, "Date of Birth error message is not displayed");
                Assert.That(Page.RegisterAccountPage.StreetErrorMessage.Displayed, Is.True, "Street error message is not displayed");
                Assert.That(Page.RegisterAccountPage.PostalCodeErrorMessage.Displayed, Is.True, "Postal Code error message is not displayed");
                Assert.That(Page.RegisterAccountPage.CityErrorMessage.Displayed, Is.True, "City error message is not displayed");
                Assert.That(Page.RegisterAccountPage.StateErrorMessage.Displayed, Is.True, "State error message is not displayed");
                Assert.That(Page.RegisterAccountPage.CountryErrorMessage.Displayed, Is.True, "Country error message is not displayed");
                Assert.That(Page.RegisterAccountPage.PhoneErrorMessage.Displayed, Is.True, "Phone error message is not displayed");
                Assert.That(Page.RegisterAccountPage.EmailErrorMessage.Displayed, Is.True, "Email error message is not displayed");
                Assert.That(Page.RegisterAccountPage.PasswordErrorMessage.Displayed, Is.True, "Password error message is not displayed");
            });
        }

        [Then("The password is either valid or invalid")]
        public void ThenThePasswordIsEitherValidOrInvalid()
        {
            // Perform BVA
            if (account.Password.Length == 0)
            {
                Assert.That(Page.RegisterAccountPage.PasswordErrorMessage.Displayed, Is.True, "Password error message is not displayed for empty password");
            }
            else if (account.Password.Length <= 7 && account.Password.Length > 0)
            {
                Assert.That(Page.RegisterAccountPage.PasswordErrorMessage.Displayed, Is.True, "Password error message is not displayed for password less than or equal to 7 characters");
            }
            else if (account.Password.Length >= 8)
            {
                Assert.Throws<OpenQA.Selenium.NoSuchElementException>(() =>
                {
                    // Accessing Displayed should throw an exception if the error message is not present for a valid password
                    var displayed = Page.RegisterAccountPage.PasswordErrorMessage.Displayed;
                }, "An exception was expected when checking for password error message with a valid password");
            }
        }

        [Then("I receive an error message stating that an account already exists")]
        public void ThenIReceiveAnErrorMessageStatingThatAnAccountAlreadyExists()
        {
            // Explicit wait for the error message to be displayed
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => Page.RegisterAccountPage.EmailAlreadyExistsErrorMessage.Displayed);

            Assert.That(Page.RegisterAccountPage.EmailAlreadyExistsErrorMessage.Displayed, Is.True, "Email already exists error message is not displayed");
        }



    }
}
