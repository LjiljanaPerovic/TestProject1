using OpenQA.Selenium;
using NUnit.Framework;

namespace ConsoleApplication1
{
    public class SwitchWindows:Page
    {

        public void Visit()
        {
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-switch-windows/";
        }
        public void ClickAlertButton()
        {
            driver.FindElement(By.Id("alert")).Click();
        }
        
        public void OpenAlertPopup()
        {
            driver.SwitchTo().Alert();
        }
        public void CheckTextInAlertPopup()
        {
            string expectedText = "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";
            Assert.AreEqual(expectedText, driver.SwitchTo().Alert().Text);
        }
      


    }
}
