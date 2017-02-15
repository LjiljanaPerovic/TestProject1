using OpenQA.Selenium;
namespace ConsoleApplication1
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebDriver driver { get; set; }

        public void Visit()
        {
            driver.Url = "http://store.demoqa.com/products-page/your-account/";
        }

        public IWebElement PasswordField { get { return driver.FindElement(By.Id("pwd")); } }
        public IWebElement UsernameField { get { return driver.FindElement(By.Id("log")); } }
        public void ClickLoginButton()
        {
            IWebElement button = driver.FindElement(By.Name("submit"));
            button.Submit();
        }
    }
}
