using OpenQA.Selenium;

namespace TestingToolshopDemoWithSelenium.Pages
{
    public class HomePage(IWebDriver driver) : WebPage(driver)
    {
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Search(string searchText)
        {
            SearchBox.SendKeys(searchText);
            SearchBox.SendKeys(Keys.Enter);
        }

        public List<string> CardTitles()
        {
            var cards = driver.FindElements(By.ClassName("card"));
            List<string> cardTitles = new List<string>();

            foreach (var card in cards)
            {
                var titleElement = card.FindElement(By.ClassName("card-title"));
                cardTitles.Add(titleElement.Text);
            }

            return cardTitles;
        }
    }
}
