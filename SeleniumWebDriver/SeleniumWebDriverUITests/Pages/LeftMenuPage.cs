using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SeleniumWebDriverUITests.Pages
{
    public class LeftMenuPage : PageObject
    {
        [FindsBy(How=How.XPath, Using = "//*[@id='left-sidebar-wrapper']/ul/li[1]/a")]
        private IWebElement _dasboardLink;
        [FindsBy(How=How.XPath, Using = "//*[@id='left-sidebar-wrapper']/ul/li[24]/a")]
        private IWebElement _reportsLink;

        public LeftMenuPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public DashboardPage GoToDashboardPage()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _dasboardLink);
            Thread.Sleep(500);

            _dasboardLink.Click();

            return new DashboardPage(_driver);
        }

        public ReportsPage GoToReportsPage()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _reportsLink);
            Thread.Sleep(500);

            _reportsLink.Click();

            return new ReportsPage(_driver);
        }
    }
}
