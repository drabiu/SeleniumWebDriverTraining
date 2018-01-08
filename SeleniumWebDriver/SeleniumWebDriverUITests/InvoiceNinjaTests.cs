using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverUITests.Pages;

namespace SeleniumWebDriverUITests
{
    [TestClass]
    public class InvoiceNinjaTests
    {
        private const string _url = "http://79.137.68.21/login";
        private const string _email = "test1@geekacademy.test";
        private const string _password = "5143testX";

        private IWebDriver _driver;

        [TestInitialize]
        public void Init()
        {
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void LoginPageShouldShowDashboardAfterEnteringCredentials()
        {
            LogIn(_url, _email, _password);

            string pageTitle = _driver.Title;

            Assert.AreEqual("Dashboard | Invoice Ninja", pageTitle);
        }

        [TestMethod]
        public void DashboardShouldSuccessfullyLogoutUser()
        {
            var dashboard = LogIn(_url, _email, _password);

            dashboard.LogoutUser();
            string pageTitle = _driver.Title;

            Assert.AreEqual("Invoice Ninja | Free Open-Source Online Invoicing", pageTitle);
        }

        [TestMethod]
        public void LeftMenuAfterClickingLinkShouldDisplayReportsPage()
        {
            var dashboard = LogIn(_url, _email, _password);

            var reports = dashboard.GoToReportsPage();
            string pageTitle = _driver.Title;

            Assert.AreEqual("Charts & Reports | Invoice Ninja", pageTitle);
        }

        [TestMethod]
        public void LeftMenuAfterClickingLinkShouldDisplayDashboardPage()
        {
            var dashboard = LogIn(_url, _email, _password);

            var reports = dashboard.GoToReportsPage();
            dashboard = reports.GoToDashboardPage();

            string pageTitle = _driver.Title;

            Assert.AreEqual("Dashboard | Invoice Ninja", pageTitle);
        }

        [TestMethod]
        public void LeftMenuAfterClickingLinkShouldDisplayTasksPage()
        {
            var dashboard = LogIn(_url, _email, _password);

            var tasks = dashboard.GoToTasksPage();

            string pageTitle = _driver.Title;

            Assert.AreEqual("Tasks | Invoice Ninja", pageTitle);
        }

        [TestCleanup]
        public void End()
        {
            _driver.Quit();
        }

        private DashboardPage LogIn(string url, string email, string password)
        {
            _driver.Navigate().GoToUrl(url);
            var loginPage = new LoginPage(_driver);

            return loginPage.LoginUsingCredentials(email, password);
        }
    }
}
