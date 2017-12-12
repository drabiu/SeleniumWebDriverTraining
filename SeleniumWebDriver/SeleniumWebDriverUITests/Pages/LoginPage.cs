using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriverUITests.Pages
{
    public class LoginPage
    {
        [FindsBy(How=How.Id, Using="email")]
        private IWebElement _loginInput;

        [FindsBy(How=How.Id, Using="password")]
        private IWebElement _passwordInput;

        [FindsBy(How=How.Id, Using="loginButton")]
        private IWebElement _submitButton;

        private IWebDriver _driver;

        public LoginPage(IWebDriver webDriver)
        {
            _driver = webDriver;
            PageFactory.InitElements(_driver, this);
        }
    }
}
