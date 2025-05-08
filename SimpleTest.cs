using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestingToolshopDemoWithSelenium
{
    public class SimpleTest
    {
        private static IWebDriver driver;
        protected Uri GridUrl;
        private WebDriverWait wait;

        [OneTimeSetUp]
        public void SetUp()
        {
            GridUrl = new Uri("http://localhost:4444/wd/hub");

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");

            driver = new RemoteWebDriver(GridUrl, chromeOptions);
            driver.Manage().Window.Maximize();

            // Set explicit wait
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
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

            // Wait for the page to load
            wait.Until(d => d.Title.Contains("Practice Software Testing"));

            string pageTitle = driver.Title;

            Assert.That(pageTitle, Is.EqualTo("Practice Software Testing - Toolshop - v5.0"));
        }
    }
}
