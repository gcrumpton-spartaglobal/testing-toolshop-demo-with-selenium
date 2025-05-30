﻿using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class WebPage(IWebDriver driver)
    {
        protected const string BaseUrl = "https://practicesoftwaretesting.com/";

        public IWebElement SearchBox => driver.FindElement(By.Id("search-query"));
        public IWebElement CartIcon => driver.FindElement(By.XPath("//a[@class='nav-link' and @data-test='nav-cart']"));
        public string PageTitle => driver.Title;
    }
}
