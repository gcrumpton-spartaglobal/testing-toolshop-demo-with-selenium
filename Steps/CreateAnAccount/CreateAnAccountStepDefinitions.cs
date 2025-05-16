using System;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps.CreateAnAccount
{
    [Binding]
    public class CreateAnAccountStepDefinitions : BaseStepDefinitions
    {
        [When("I click {string}")]
        public void WhenIClick(string p0)
        {
            throw new PendingStepException();
        }

        [When("I fill out the form with the following information:")]
        public void WhenIFillOutTheFormWithTheFollowingInformation(DataTable dataTable)
        {
            var accounts = dataTable.CreateSet<Account>();
            var registerAccountPage = new RegisterAccountPage(Driver);

            foreach (var account in accounts)
            {
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
        }

        [When("I click on the {string} button")]
        public void WhenIClickOnTheButton(string register)
        {
            throw new PendingStepException();
        }
    }
}
