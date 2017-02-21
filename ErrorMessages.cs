using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ErrorMessages
    {
        public void RequiredFieldErrorMessageShouldBEDisplayed(By by)
        {
            IWebElement errormessage = WebElementChecks.ShouldBeDisplayed(by);
            Assert.AreEqual("* This field is required", errormessage.Text);
        }

    }
}
