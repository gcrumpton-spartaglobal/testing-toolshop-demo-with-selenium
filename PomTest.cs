using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

            var cards = _driver.FindElements(By.ClassName("card"));
            List<string> cardTitles = new List<string>();

            foreach (var card in cards)
            {
                var titleElement = card.FindElement(By.ClassName("card-title"));
                cardTitles.Add(titleElement.Text);
                Console.WriteLine(titleElement.Text);
            }

            Assert.That(cardTitles, Has.Count.EqualTo(4));
        }
    }
}
