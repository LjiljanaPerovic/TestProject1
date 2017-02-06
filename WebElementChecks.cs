
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public static class WebElementChecks
{
    public static IWebElement ShouldBeDisplayed(IWebDriver driver, By by)
    {
        var interval = TimeSpan.FromSeconds(5);
        WebDriverWait wait = new WebDriverWait(driver, interval);
        return wait.Until(ExpectedConditions.ElementIsVisible(by));
    }

}