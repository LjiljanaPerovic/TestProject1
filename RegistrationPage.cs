﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleApplication1
{
    
    public class RegistrationPage
    {
       
        IWebDriver driver { get; set; }
        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenHomePage()
        {
            driver.Url = "http://demoqa.com";
        }

        public void ClickRegistrationLink()
        {
            IWebElement link = driver.FindElement(By.CssSelector("#menu-item-374 > a:nth-child(1)"));
            link.Click();
        }

        public void WaitRegistrationPageLoad()
        {
            WebElementChecks.ShouldBeDisplayed(driver, By.Id("name_3_firstname"));
        }

        public void EnterFirstName(string text)
        {
            IWebElement firstName = driver.FindElement(By.Id("name_3_firstname"));
            firstName.SendKeys(text);
        }

        public void EnterLastName(string text)
        {
            IWebElement lastName = driver.FindElement(By.Id("name_3_lastname"));
            lastName.SendKeys(text);
        }

        public void ChooseMaritalStatus(string maritalStatus)
        {
           var radio = driver.FindElement(By.CssSelector("input[name='radio_4[]'][value='" + maritalStatus + "']"));
           radio.Click();          
        }

        public void ChooseHobby(string hobby)
        {
            driver.FindElement(By.CssSelector("input[value='" + hobby + "']")).Click();
        }

        public void SelectCountry()
        {
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Id("dropdown_7")));
            selectCountry.SelectByValue("Bolivia");
        }

        public void SelectBirthMonth()
        {
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("mm_date_8")));
            selectMonth.SelectByText("5");
        }

        public void SelectBirthDay()
        {
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("dd_date_8")));
            selectDay.SelectByText("18");
        }

        public void SelectBirthYear()
        {
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("yy_date_8")));
            selectYear.SelectByText("1980");
        }

        public void EnterPhoneNumber(string text)
        {
            IWebElement phoneNumber = driver.FindElement(By.Id("phone_9"));
            phoneNumber.SendKeys(text);
        }

        public void EnterUsername()
        {
            IWebElement userName = driver.FindElement(By.Id("username"));
            userName.SendKeys(Guid.NewGuid().ToString());
        }

        public void EnterEmail(string text)
        {
            IWebElement email = driver.FindElement(By.Id("email_1"));
            email.SendKeys(text);
        }

        public void EnterPassword(string text)
        {
            IWebElement pass = driver.FindElement(By.Id("password_2"));
            pass.SendKeys(text);
        }

        public void ConfirmPassword(string text)
        {
            IWebElement confPass = driver.FindElement(By.Id("confirm_password_password_2"));
            confPass.SendKeys(text);
        }

        public void SubmitRegistrationForm()
        {
            var djoka = By.Name("pie_submit");
            IWebElement submit = driver.FindElement(djoka);
            submit.Click();
        }

        public SelectElement SelectMonth
        {
            get { return new SelectElement(driver.FindElement(By.Id("mm_date_8"))); }
        }

        const string xpathForFirstNameAndLastNameError = "//*[@id='pie_register']/li[1]/div[1]/div[2]/span";

        public void FirstNameRequiredErrorMessageShouldBeDisplayed()
        {
            RequiredFieldErrorMessageShouldBEDisplayed(By.XPath(xpathForFirstNameAndLastNameError));
        }

        public void LastNameREquiredErrorMessageShouldBeDisplayed()
        {
            RequiredFieldErrorMessageShouldBEDisplayed(By.XPath(xpathForFirstNameAndLastNameError));
        }

        private void RequiredFieldErrorMessageShouldBEDisplayed(By by)
        {
            IWebElement errormessage = WebElementChecks.ShouldBeDisplayed(driver, by);
            Assert.AreEqual("* This field is required", errormessage.Text);
        }
    }
   
    
}
