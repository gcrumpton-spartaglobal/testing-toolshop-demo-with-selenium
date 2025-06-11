using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingToolshopDemoWithSelenium.Pages;

namespace TestingToolshopDemoWithSelenium.Steps
{
    public class BaseStepDefinitions
    {
        protected Uri GridUrl;
        public static IWebDriver Driver { get; set; }
        private DriverOptions _driverOptions;

        // Allow browser selection per scenario
        public string Browser { get; set; } = "chrome";

        [OneTimeSetUp]
        public void SetUp()
        {
            GridUrl = new Uri("http://localhost:4444/wd/hub");

            switch(Browser.ToLower())
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

            Driver = new RemoteWebDriver(
                GridUrl, 
                _driverOptions.ToCapabilities(),
                TimeSpan.FromSeconds(180)
                );
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}
