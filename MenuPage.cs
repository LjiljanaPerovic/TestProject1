using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class MenuPage:Page
    {
        public void OpenMenuPage()
        {
            driver.Url = "http://demoqa.com/menu/";
        }
        public void CheckMenuPageLoaded()
        {
            WebElementChecks.ShouldBeDisplayed(By.ClassName("page-id-43"));
            Assert.AreEqual("http://demoqa.com/menu/", driver.Url);
        }
        public List<IWebElement> MenuItems
        {
            get
            {
                return new List<IWebElement>(driver.FindElements(By.CssSelector("#tabs-1 #navigate .ui-corner-left")));
            }
        }       
        
    }
}
