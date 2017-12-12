using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverUITests.Pages;

namespace SeleniumWebDriverUITests
{
    [TestClass]
    public class InvoiceNinjaTests
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void Init()
        {
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void LoginPageShouldShowDashboardAfterEnteringCredentials()
        {
            //var loginPage = new LoginPage(_driver);
            _driver.Navigate().GoToUrl("http://79.137.68.21/login");
            IWebElement loginInput = _driver.FindElement(By.Id("email"));
            IWebElement passwordInput = _driver.FindElement(By.Id("password"));
            IWebElement submitButton = _driver.FindElement(By.Id("loginButton"));

            loginInput.SendKeys("test1@geekacademy.test");
            passwordInput.SendKeys("5143testX");
            submitButton.Click();

            string pageTitle = _driver.Title;

            Assert.AreEqual("Dashboard | Invoice Ninja", pageTitle);
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestCleanup]
        public void End()
        {
            _driver.Quit();
        }
    }
}
