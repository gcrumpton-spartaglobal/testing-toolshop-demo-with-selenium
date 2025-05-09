using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestingToolshopDemoWithSelenium.Steps
{
    public class BaseStepDefinitions
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
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
    }
}
