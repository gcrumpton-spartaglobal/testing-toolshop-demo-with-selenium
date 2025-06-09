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
            contactPage.SubjectInput.SendKeys(contactForm.Subject);
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
            Assert.Multiple(() =>
            {
                Assert.That(Page.ContactPage.FirstNameErrorMessage.Displayed, Is.True, "First Name error message is not displayed");
                Assert.That(Page.ContactPage.LastNameErrorMessage.Displayed, Is.True, "Last Name error message is not displayed");
                Assert.That(Page.ContactPage.EmailErrorMessage.Displayed, Is.True, "Email error message is not displayed");
                Assert.That(Page.ContactPage.SubjectErrorMessage.Displayed, Is.True, "Subject error message is not displayed");
                Assert.That(Page.ContactPage.MessageIsRequiredErrorMessage.Displayed, Is.True, "Message is required error message is not displayed");
            });
        }

        [Then("I receive an error or success message")]
        public void ThenIReceiveAnErrorOrSuccessMessage()
        {
            // Explicit wait for the message to be displayed
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            // Perform BVA
            if (contactForm.Message.Length == 0)
            {                
                wait.Until(drv => Page.ContactPage.MessageIsRequiredErrorMessage.Displayed);

                Assert.That(Page.ContactPage.MessageIsRequiredErrorMessage.Displayed, Is.True);
            }
            else if (contactForm.Message.Length >= 1 && contactForm.Message.Length <= 49)
            {
                wait.Until(drv => Page.ContactPage.MessageIsTooShortErrorMessage.Displayed);

                Assert.That(Page.ContactPage.MessageIsTooShortErrorMessage.Displayed, Is.True);
            }
            else if (contactForm.Message.Length >= 50 && contactForm.Message.Length <= 250)
            {
                wait.Until(drv => Page.ContactPage.FormSentMessage.Displayed);

                Assert.That(Page.ContactPage.FormSentMessage.Displayed, Is.True);
            }
            else if (contactForm.Message.Length > 250)
            {
                wait.Until(drv => Page.ContactPage.MessageIsTooLongErrorMessage.Displayed);

                Assert.That(Page.ContactPage.MessageIsTooLongErrorMessage.Displayed, Is.True);
            }
        }


    }
}
