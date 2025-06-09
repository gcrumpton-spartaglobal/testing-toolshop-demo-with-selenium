using System;
using Reqnroll;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps.SendContactForm
{
    [Binding]
    public class SendContactFormStepDefinitions : BaseStepDefinitions
    {
        private ContactForm contactForm;

        [When("I fill out the contact form with the following information:")]
        public void WhenIFillOutTheContactFormWithTheFollowingInformation(DataTable dataTable)
        {
            contactForm = dataTable.CreateInstance<ContactForm>();
            var contactPage = new ContactPage(Driver);

            // Fill out the contact form
            contactPage.FirstNameInput.SendKeys(contactForm.FirstName);
            contactPage.LastNameInput.SendKeys(contactForm.LastName);
            contactPage.EmailInput.SendKeys(contactForm.Email);
            contactPage.SubjectInput.SendKeys(contactForm.Subject);
            contactPage.MessageInput.SendKeys(contactForm.Message);
        }

        [Then("I receive a confirmation message")]
        public void ThenIReceiveAConfirmationMessage()
        {
            throw new PendingStepException();
        }
    }
}
