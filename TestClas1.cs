using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{

    [TestFixture]
    public class TestClas1
    {
        static void Main() { }
        IWebDriver driver;
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void ExampleTest1()
        {
            driver.Url = "http://store.demoqa.com/";
            string title = driver.Title;
            System.Int32 lenght = title.Length;
            Console.Write(title);
            Console.Write(lenght);

            string url = driver.Url;
            System.Console.Write(url);
            System.Console.Write(url.Length);

            string pagesource = driver.PageSource;
            System.Console.Write(pagesource);
            System.Console.Write(pagesource.Length);
        }

        [Test]
        public void ExampleTest2()
        {
            driver.Url = "http://demoqa.com/";
            //driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();
            //driver.Navigate().Back();
            //driver.Navigate().Forward();
            //driver.Navigate().GoToUrl(driver.Url);
            //driver.Navigate().Refresh();
        }

        [Test]
        public void ExampleTest3()
        {
            driver.Url = "http://demoqa.com/";
            IWebElement element = driver.FindElement(By.ClassName("entry-title"));
            string title = "Home";
            Assert.AreEqual(title, element.Text);
        }

        [Test]
        public void ExampleTest4()
        {
            driver.Url = "http://demoqa.com/";
            IWebElement tabMenu = driver.FindElement(By.Id("ui-id-3"));
            tabMenu.Click();
            IWebElement tab = driver.FindElement(By.Id("tabs-3"));
            Assert.IsTrue(tab.Enabled);           
        }

        [Test]
        public void ExampleTest5()
        {
            driver.Url = "http://store.demoqa.com/";
            IWebElement linkMyAcc = driver.FindElement(By.LinkText("AccountMy Account"));
            linkMyAcc.Click();
            var interval = TimeSpan.FromSeconds(5);
            WebDriverWait wait = new WebDriverWait(driver, interval);
            wait.Until(ExpectedConditions.ElementExists(By.Id("login")));
            Assert.AreEqual("http://store.demoqa.com/products-page/your-account/", driver.Url, "nije dobar url");
            IWebElement login = driver.FindElement(By.Id("login"));
            IWebElement label = driver.FindElement(By.ClassName("response"));
            Assert.IsFalse(label.Displayed, "it is visible");
            login.Click();
            wait.Until(ExpectedConditions.TextToBePresentInElement(label, "Please enter your username and password."));
            Assert.IsTrue(label.Displayed, "nije label vidljiv");
            Assert.AreEqual("Please enter your username and password.", label.Text);
        }

     

        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }


 

}
