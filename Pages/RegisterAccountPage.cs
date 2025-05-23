﻿using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class RegisterAccountPage(IWebDriver driver) : WebPage(driver)
    {
        public IWebElement FirstNameInput => driver.FindElement(By.Id("first_name"));
        public IWebElement LastNameInput => driver.FindElement(By.Id("last_name"));
        public IWebElement DateOfBirthInput => driver.FindElement(By.Id("dob"));
        public IWebElement StreetInput => driver.FindElement(By.Id("street"));
        public IWebElement PostalCodeInput => driver.FindElement(By.Id("postal_code"));
        public IWebElement CityInput => driver.FindElement(By.Id("city"));
        public IWebElement StateInput => driver.FindElement(By.Id("state"));
        public IWebElement CountryInput => driver.FindElement(By.Id("country"));
        public IWebElement PhoneInput => driver.FindElement(By.Id("phone"));
        public IWebElement EmailInput => driver.FindElement(By.Id("email"));
        public IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        public IWebElement RegisterButton => driver.FindElement(By.XPath("//button[@data-test='register-submit']"));

        public void GoToRegisterAccountPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "auth/register");
        }
    }
}
