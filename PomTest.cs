using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestingToolshopDemoWithSelenium.Pages;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace TestingToolshopDemoWithSelenium
{
    public class PomTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }

        [Test]
        public void CheckTitle()
        {
            var homePage = new HomePage(_driver);

            homePage.GoToHomePage();

            string pageTitle = homePage.PageTitle;

            Assert.That(pageTitle, Is.EqualTo("Practice Software Testing - Toolshop - v5.0"));
        }

        [Test]
        public void SearchForPliersContainsFourResults()
        {
            var homePage = new HomePage(_driver);

            homePage.GoToHomePage();
            homePage.Search("Pliers");

            // Wait for the search results to load
            Thread.Sleep(5000);

            // Obtain the card titles after the search
            var cardTitles = homePage.CardTitles();

            Assert.That(cardTitles, Has.Count.EqualTo(4));
        }

        [Test]
        public void CheckSignInPageHasLoginText()
        {
            var signInPage = new SignInPage(_driver);

            signInPage.GoToSignInPage();

            string loginText = signInPage.LoginText.Text;

            Assert.That(loginText, Is.EqualTo("Login"));
        }
    }
}
