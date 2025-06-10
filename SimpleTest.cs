using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace TestingToolshopDemoWithSelenium
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [TestFixture("edge")]
    [Parallelizable(ParallelScope.All)]
    public class SimpleTest
    {
        public IWebDriver Driver { get; set; }
        private WebDriverWait _wait;
        private DriverOptions _driverOptions;
        public string Browser { get; set; }
        protected Uri GridUrl;

        public SimpleTest(string browser)
        {
            Browser = browser;
        }

        [SetUp]
        public void SetUp()
        {
            GridUrl = new Uri("http://localhost:4444/wd/hub");

            switch (Browser.ToLower())
            {
                case "chrome":
                    _driverOptions = new ChromeOptions();
                    break;
                case "firefox":
                    _driverOptions = new FirefoxOptions();
                    break;
                case "edge":
                    _driverOptions = new EdgeOptions();
                    break;
                default:
                    throw new ArgumentException($"Unsupported browser: {Browser}");
            }

            Driver = new RemoteWebDriver(GridUrl, _driverOptions.ToCapabilities());
            Driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(5));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }

        [Test]
        public void CheckTitle()
        {
            Driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/");
            _wait.Until(d => d.Title.Contains("Practice Software Testing"));
            string pageTitle = Driver.Title;
            Assert.That(pageTitle, Is.EqualTo("Practice Software Testing - Toolshop - v5.0"));
        }
    }
}
