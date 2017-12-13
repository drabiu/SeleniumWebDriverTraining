using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriverUITests.Pages
{
    public class DashboardPage : PageObject
    {
        [FindsBy(How=How.XPath, Using = "//*[@id='navbar-collapse-1']/div/div/ul/li[3]/a")]
        private IWebElement _logoutLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='navbar-collapse-1']/div/div/button")]
        private IWebElement _accountDetailsButton;

        public DashboardPage(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public void LogoutUser()
        {
            _accountDetailsButton.Click();
            _logoutLink.Click();
        }
    }
}
