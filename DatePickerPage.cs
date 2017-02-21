using NUnit.Framework;
using OpenQA.Selenium;

namespace ConsoleApplication1
{
    public class DatePickerPage:Page
    {
        public void Visit()
        {
            driver.Url = "http://demoqa.com/datepicker/";
        }
        public void ClickFormatDateMenuItem()
        {
            driver.FindElement(By.CssSelector("a[id=ui-id-4]")).Click();
            IWebElement panel = driver.FindElement(By.CssSelector("div[id=tabs-4]"));
            Assert.IsTrue(panel.Displayed);
        }
    }
}
