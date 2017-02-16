using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [SetUpFixture]
    class BaseClass
    {
        public static IWebDriver driver;
        
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
