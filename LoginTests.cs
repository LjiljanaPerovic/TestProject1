using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    [TestFixture]
    public class LoginTests
    {
      
        LoginPage loginPage;

        //[OneTimeSetUp]
        //public void Initialize()
        //{
        //    driver = new FirefoxDriver();
        //}

        [SetUp]
        public void Setup()
        {
            loginPage = new LoginPage();
            loginPage.Visit();
        }

        [Test]
        public void LoginWorks()
        {
            loginPage.UsernameField.SendKeys("Lica");
            loginPage.PasswordField.SendKeys("pass1");
            loginPage.ClickLoginButton();
        }

        [Test]
        public void LoginGivesErrorForWrongPassword()
        {
            loginPage.UsernameField.SendKeys("Lica");
            loginPage.PasswordField.SendKeys("WrongPassword");
            loginPage.ClickLoginButton();
        }

       
        //[OneTimeTearDown]
        //public void EndTest()
        //{
        //    driver.Close();
        //    driver.Quit();
        //}
    }

   

}
