using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ConsoleApplication1
{
    [TestFixture]
    public class MenuPageTests
    {
        IWebDriver driver;
        MenuPage menupage;
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [SetUp]
        public void SetUp()
        {
            menupage = new MenuPage(driver);
        }
        [Test]
        public void CheckMenuItems()
        {
            menupage.OpenMenuPage();
            menupage.CheckMenuPageLoaded();
            var menuItems = menupage.MenuItems;
            Assert.AreEqual(5, menuItems.Count);
            Assert.AreEqual("Home", menuItems[0].Text);
            Assert.AreEqual("About", menuItems[1].Text);
            Assert.AreEqual("Contact", menuItems[2].Text);
            Assert.AreEqual("FAQ", menuItems[3].Text);
            Assert.AreEqual("News", menuItems[4].Text);
        }

        [TearDown]
        public void EndWindow()
        {
            driver.Close();
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
