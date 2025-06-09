using System;
using OpenQA.Selenium.Support.UI;
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
            contactPage.SubjectInput.SendKeys(contactForm.Subject.Trim( '/', '"'));
            contactPage.MessageInput.SendKeys(contactForm.Message);
        }

        [Then("I receive a confirmation message")]
        public void ThenIReceiveAConfirmationMessage()
        {
            // Explicit wait for the form sent message to be displayed
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => Page.ContactPage.FormSentMessage.Displayed);

            Assert.That(Page.ContactPage.FormSentMessage.Displayed, Is.True);
        }

        [Then("I receive an error message for each field on the contact form")]
        public void ThenIReceiveAnErrorMessageForEachFieldOnTheContactForm()
        {
            throw new PendingStepException();
        }

    }
}
