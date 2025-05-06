using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingToolshopDemoWithSelenium
{
    public class SimpleTest
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");

            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
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
