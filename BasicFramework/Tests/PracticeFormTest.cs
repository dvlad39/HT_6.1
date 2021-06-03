using System;
using BasicFramework.Framework;
using BasicFramework.Framework.Models;
using BasicFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace BasicFramework.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        private User _user;
        


        [SetUp]
        protected void Initialize()
        {
            _user = User.GetDefaultUser();
        }

        [Test]
        public void ValidLoginTest()
        {
            HomePage homePage = SiteNavigator.NavigateToLoginPage(Driver).Login(_user);

            Logger.Info("Wait example");
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("submit")));
            IWebElement title = Driver.FindElement(By.CssSelector("#example-modal-sizes-title-lg"));
            Assert.IsNotNull(title);





        }
    }
}