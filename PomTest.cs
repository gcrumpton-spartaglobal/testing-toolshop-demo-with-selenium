﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium
{
    public class PomTest
    {
        private static IWebDriver _driver;
        protected Uri GridUrl;

        [OneTimeSetUp]
        public void SetUp()
        {
            GridUrl = new Uri("http://localhost:4444/wd/hub");

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");

            _driver = new RemoteWebDriver(GridUrl, chromeOptions);
            _driver.Manage().Window.Maximize();

            // Set implicit wait
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
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
