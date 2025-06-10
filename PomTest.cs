using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using TestingToolshopDemoWithSelenium.Pages;
using OpenQA.Selenium.Support.UI;

namespace TestingToolshopDemoWithSelenium
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [TestFixture("edge")]
    [Parallelizable(ParallelScope.All)]
    public class PomTest
    {
        public IWebDriver Driver { get; set; }
        public string Browser { get; set; }
        private DriverOptions _driverOptions;
        protected Uri GridUrl;

        public PomTest(string browser)
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
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }

        [Test]
        public void CheckTitle()
        {
            var homePage = new HomePage(Driver);
            homePage.GoToHomePage();
            string pageTitle = homePage.PageTitle;
            Assert.That(pageTitle, Is.EqualTo("Practice Software Testing - Toolshop - v5.0"));
        }

        [Test]
        public void SearchForPliersContainsFourResults()
        {
            var homePage = new HomePage(Driver);
            homePage.GoToHomePage();
            homePage.Search("Pliers");
            Thread.Sleep(10000);
            // Explicit wait for the 4 results to be displayed
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElements(By.CssSelector(".card")).Count == 4);

            var cardTitles = homePage.CardTitles();
            Assert.That(cardTitles, Has.Count.EqualTo(4));
        }

        [Test]
        public void CheckSignInPageHasLoginText()
        {
            var signInPage = new SignInPage(Driver);
            signInPage.GoToSignInPage();
            string loginText = signInPage.LoginText.Text;
            Assert.That(loginText, Is.EqualTo("Login"));
        }
    }
}
