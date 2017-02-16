using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ConsoleApplication1
{
    [TestFixture]
    public class RegistrationTest
    {
        IWebDriver driver;
        RegistrationPage registrationPage;
        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [SetUp]
        public void SetUp()
        {
            registrationPage = new RegistrationPage(driver);
        }

        [Test]
        public void SuccessfulRegistration()
        {
            registrationPage.OpenRegistrationPage();
            registrationPage.EnterFirstName("Lilly");
            registrationPage.EnterLastName("Lillic");
            registrationPage.ChooseMaritalStatus("divorced");
            registrationPage.ChooseHobby("reading");
            registrationPage.SelectCountry.SelectByText("Barbados");
            registrationPage.SelectBirthMonth.SelectByText("5");
            registrationPage.SelectBirthDay.SelectByValue("24");
            registrationPage.SelectBirthYear.SelectByValue("1975");
            registrationPage.EnterPhoneNumber("44075123456");
            registrationPage.EnterUsername();
            registrationPage.EnterEmail("lillylylli12@gmail.com");
            registrationPage.EnterPassword("lilly123");
            registrationPage.ConfirmPassword("lilly123");
            registrationPage.SubmitRegistrationForm();
            WebElementChecks.ShouldBeDisplayed(driver, By.ClassName("piereg_message"));
        }

        [Test]
        public void CheckIsEmptyFirstname()
        {
            registrationPage.OpenRegistrationPage();
            registrationPage.EnterFirstName(string.Empty);
            registrationPage.EnterLastName(string.Empty);
            registrationPage.ChooseHobby("cricket ");
            registrationPage.ChooseMaritalStatus("married");
            registrationPage.EnterEmail("perrrrra@jvmgvnjgvjgvhg.com");
            registrationPage.EnterPassword("perazdera");
            registrationPage.EnterPhoneNumber("12345678901");
            registrationPage.EnterUsername();
            registrationPage.SelectBirthDay.SelectByValue("15");
            registrationPage.SelectBirthMonth.SelectByValue("7");
            registrationPage.SelectBirthYear.SelectByValue("1999");
            registrationPage.SelectCountry.SelectByText("Greece");
            registrationPage.ConfirmPassword("perazdera");
            registrationPage.SubmitRegistrationForm();
            registrationPage.FirstNameRequiredErrorMessageShouldBeDisplayed();
        }

        [Test]
        public void CheckIsHobbyChecked()
        {
            registrationPage.OpenRegistrationPage();
            registrationPage.EnterFirstName("Sneza");
            registrationPage.EnterLastName("Snezic");
            registrationPage.EnterPhoneNumber("4407523232356");
            registrationPage.EnterUsername();
            registrationPage.EnterEmail("sdfdfdf@gmail.com");
            registrationPage.EnterPassword("snezasneza");
            registrationPage.ConfirmPassword("snezasneza");
            registrationPage.SubmitRegistrationForm();
            registrationPage.RequiredHobbyErrorMessageShoulBeDisplayed();
        }
       
        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }

}
