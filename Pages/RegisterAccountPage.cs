using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class RegisterAccountPage(IWebDriver driver) : WebPage(driver)
    {
        #region InputFields
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
        #endregion

        #region ErrorMessages
        public IWebElement FirstNameErrorMessage => driver.FindElement(By.XPath("//div[@data-test='first-name-error']"));
        public IWebElement LastNameErrorMessage => driver.FindElement(By.XPath("//div[@data-test='last-name-error']"));
        public IWebElement DateOfBirthErrorMessage => driver.FindElement(By.XPath("//div[@data-test='dob-error']"));
        public IWebElement StreetErrorMessage => driver.FindElement(By.XPath("//div[@data-test='street-error']"));
        public IWebElement PostalCodeErrorMessage => driver.FindElement(By.XPath("//div[@data-test='postal_code-error']"));
        public IWebElement CityErrorMessage => driver.FindElement(By.XPath("//div[@data-test='city-error']"));
        public IWebElement StateErrorMessage => driver.FindElement(By.XPath("//div[@data-test='state-error']"));
        public IWebElement CountryErrorMessage => driver.FindElement(By.XPath("//div[@data-test='country-error']"));
        public IWebElement PhoneErrorMessage => driver.FindElement(By.XPath("//div[@data-test='phone-error']"));
        public IWebElement EmailErrorMessage => driver.FindElement(By.XPath("//div[@data-test='email-error']"));
        #endregion

        public void GoToRegisterAccountPage()
        {
            driver.Navigate().GoToUrl(BaseUrl + "auth/register");
        }
    }
}
