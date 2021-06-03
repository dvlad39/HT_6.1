using BasicFramework.Framework.Models;
using OpenQA.Selenium;
using System;
using System.IO;

namespace BasicFramework.Pages
{
    public class PracticeForm : BasePage
    {
        public PracticeForm(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstNameBox => Driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameBox => Driver.FindElement(By.Id("lastName"));
        private IWebElement EmailBox => Driver.FindElement(By.Id("userEmail"));
        private IWebElement GenderBox => Driver.FindElement(By.XPath("//*[@class = 'custom-control custom-radio custom-control-inline'] // child :: label"));   
        private IWebElement MobileBox => Driver.FindElement(By.Id("userNumber"));
        private IWebElement DateOfBirthBox => Driver.FindElement(By.Id("dateOfBirthInput")); 
        private IWebElement ChooseMonth => Driver.FindElement(By.XPath("//select[@class = 'react-datepicker__month-select']//child::option[@value = '11']"));

        private IWebElement ChooseYear => Driver.FindElement(By.XPath("//select[@class = 'react-datepicker__year-select']//child::option[@value = '2000']"));
        private IWebElement ChooseDay => Driver.FindElement(By.XPath("//div[@class = 'react-datepicker__day react-datepicker__day--022']"));

        private IWebElement HobbiesBox => Driver.FindElement(By.XPath("//label[text() = 'Reading']"));
        private IWebElement Picture => Driver.FindElement(By.Id("uploadPicture"));

        private IWebElement CurrentAddressBox => Driver.FindElement(By.Id("currentAddress")); 

        private IWebElement StateBox => Driver.FindElement(By.CssSelector("#state"));
        private IWebElement StateBoxChoose => Driver.FindElement(By.XPath("//div[text() = 'Haryana']"));

        private IWebElement CityBox => Driver.FindElement(By.CssSelector("#city"));

        private IWebElement CityBoxChoose => Driver.FindElement(By.XPath("//div[text() = 'Karnal']"));
        private IWebElement SubmitButton => Driver.FindElement(By.CssSelector("#submit"));




        public HomePage Login(User user)
        {
            
            FirstNameBox.Click();
            FirstNameBox.SendKeys(user.FirstName);
            LastNameBox.Click();
            LastNameBox.SendKeys(user.LastName);
            EmailBox.Click();
            EmailBox.SendKeys(user.Email);
            GenderBox.Click();
            MobileBox.Click();
            MobileBox.SendKeys(user.Mobile);
            DateOfBirthBox.Click();
            ChooseMonth.Click();
            ChooseYear.Click();
            ChooseDay.Click();
            HobbiesBox.Click();
            CurrentAddressBox.SendKeys(user.CurrentAddress);
            Picture.SendKeys(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/GUkYjsT.jpg"));
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)Driver;
            scroll.ExecuteScript("scroll(0, 250)");
            StateBox.Click();
            StateBoxChoose.Click();
            CityBox.Click();
            CityBoxChoose.Click();
            SubmitButton.Click();
            return new HomePage(Driver);
        }
    }
}