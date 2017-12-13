using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriverUITests.Pages
{
    public class LoginPage : PageObject
    {
        [FindsBy(How=How.Id, Using="email")]
        private IWebElement _loginInput;

        [FindsBy(How=How.Id, Using="password")]
        private IWebElement _passwordInput;

        [FindsBy(How=How.Id, Using="loginButton")]
        private IWebElement _submitButton;

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public DashboardPage LoginUsingCredentials(string email, string password)
        {
            _loginInput.SendKeys(email);
            _passwordInput.SendKeys(password);
            _submitButton.Click();

            return new DashboardPage(_driver);
        }
    }
}
