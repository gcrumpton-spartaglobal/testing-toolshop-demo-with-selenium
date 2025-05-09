using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Steps
{
    public class BaseStepDefinitions
    {
        private static IWebDriver _driver;
        protected Uri GridUrl;
    }
}
