using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace TestingToolshopDemoWithSelenium
{
    public class SimpleTest
    {
        private static IWebDriver driver;
        protected Uri GridUrl;

        [OneTimeSetUp]
        public void SetUp()
        {
            GridUrl = new Uri("http://localhost:4444");

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");

            driver = new RemoteWebDriver(GridUrl, chromeOptions);
            driver.Manage().Window.Maximize();

            // Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Dispose();
        }

        [Test]
        public void CheckTitle()
        {
            driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/");
            string pageTitle = driver.Title;
            Assert.That(pageTitle, Is.EqualTo("Practice Software Testing - Toolshop - v5.0"));
        }
    }
}
