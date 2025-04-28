using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingToolshopDemoWithSelenium
{
    public class SimpleTest
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
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
