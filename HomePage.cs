using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class HomePage
    {
        IWebDriver driver { get; set; }
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void OpenHomePage()
        {
            driver.Url = "http://demoqa.com";
        }
        public void ClickRegistrationLink()
        {
            IWebElement registrationLink = driver.FindElement(By.CssSelector("#menu-item-374 > a:nth-child(1)"));
            registrationLink.Click();
        }
        public void CheckRegistrationPageLoaded()
        {
            WebElementChecks.ShouldBeDisplayed(driver, By.ClassName("page-id-49"));
            Assert.AreEqual("http://demoqa.com/registration/", driver.Url);
        }
        public void InteractionMenuVisible(string id,string text)
        {
            IWebElement interactionMenuList = driver.FindElement(By.Id(id));
            Assert.AreEqual(interactionMenuList.Text, text);
        }
    }
}
