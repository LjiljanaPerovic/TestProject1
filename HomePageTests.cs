using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ConsoleApplication1
{
    [TestFixture]
    public class HomePageTests
    {
        IWebDriver driver;
        HomePage homepage;
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [SetUp]
        public void SetUp()
        {
            homepage = new HomePage(driver);
        }

        [Test]
        public void CheckRegistrationLink()
        {
            homepage.OpenHomePage();
            homepage.ClickRegistrationLink();
            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.CheckRegistrationPageLoaded();
        }
        [Test]
        public void CheckInteractionMenu()
        {
            homepage.OpenHomePage();
            homepage.InteractionMenuVisible("menu-item-140", "Draggable");
            homepage.InteractionMenuVisible("menu-item-141", "Droppable");
            homepage.InteractionMenuVisible("menu-item-142", "Selectable");
            homepage.InteractionMenuVisible("menu-item-143", "Resizable");
            homepage.InteractionMenuVisible("menu-item-151", "Sortable");
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
