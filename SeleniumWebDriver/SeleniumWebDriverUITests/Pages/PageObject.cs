using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriverUITests.Pages
{
    public abstract class PageObject
    {
        protected IWebDriver _driver;

        public PageObject(IWebDriver webDriver)
        {
            _driver = webDriver;
            PageFactory.InitElements(_driver, this);
        }
    }
}
