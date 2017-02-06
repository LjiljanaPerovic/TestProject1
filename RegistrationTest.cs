using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ConsoleApplication1
{
    [TestFixture]
    public class RegistrationTest
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void SuccessfulRegistration()
        {
            var registrationPage = new RegistrationPage(driver);
            registrationPage.OpenHomePage();
            registrationPage.ClickRegistrationLink();
            registrationPage.WaitRegistrationPageLoad();
            WebElementChecks.ShouldBeDisplayed(driver, By.Id("name_3_firstname"));
            registrationPage.EnterFirstName("Lilly");
            registrationPage.EnterLastName("Lillic");
            registrationPage.ChooseMaritalStatus("divorced");
            registrationPage.ChooseHobby("reading");
            registrationPage.SelectCountry();
            registrationPage.SelectBirthMonth();
            //registrationPage.SelectMonth.SelectByText("5");
            registrationPage.SelectBirthDay();
            registrationPage.SelectBirthYear();
            registrationPage.EnterPhoneNumber("44075123456");
            registrationPage.EnterUsername();
            registrationPage.EnterEmail("lilly123@gmail.com");
            registrationPage.EnterPassword("lilly123");
            registrationPage.ConfirmPassword("lilly123");
            registrationPage.SubmitRegistrationForm();
            WebElementChecks.ShouldBeDisplayed(driver, By.ClassName("piereg_message"));
        }

        [Test]
        public void CheckIsEmptyFirstname()
        {
            var registrationPage = new RegistrationPage(driver);
            registrationPage.OpenHomePage();
            registrationPage.ClickRegistrationLink();
            registrationPage.WaitRegistrationPageLoad();
            registrationPage.EnterFirstName(string.Empty);
            registrationPage.EnterLastName(string.Empty);
            registrationPage.ChooseHobby("cricket ");
            registrationPage.ChooseMaritalStatus("married");
            registrationPage.EnterEmail("pera@jvmgvnjgvjgvhg.com");
            registrationPage.EnterPassword("perazdera");
            registrationPage.EnterPhoneNumber("12345678901");
            registrationPage.EnterUsername();
            registrationPage.SelectBirthDay();
            registrationPage.SelectBirthMonth();
            registrationPage.SelectBirthYear();
            registrationPage.SelectCountry();
            registrationPage.ConfirmPassword("perazdera");
            registrationPage.SubmitRegistrationForm();
            registrationPage.FirstNameRequiredErrorMessageShouldBeDisplayed();
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
