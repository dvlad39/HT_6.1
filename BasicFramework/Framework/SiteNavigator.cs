using System.Configuration;
using BasicFramework.Pages;
using OpenQA.Selenium;

namespace BasicFramework.Framework
{
    public class SiteNavigator
    {
        public static PracticeForm NavigateToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
            return new PracticeForm(driver);
        }
    }
}