
using ConsoleApplication1;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public static class WebElementChecks
{
    public static IWebElement ShouldBeDisplayed(By by)
    {

        var interval = TimeSpan.FromSeconds(5);
        WebDriverWait wait = new WebDriverWait(BaseClass.driver, interval);
        return wait.Until(ExpectedConditions.ElementIsVisible(by));
    }
}