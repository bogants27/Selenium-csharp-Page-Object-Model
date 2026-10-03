using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeNUnit.DriverFactory
{
    public  class DriverFactory
    {

        public static IWebDriver CreateDriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    return new ChromeDriver();

                case "firefox":
                    return new FirefoxDriver();

                default:
                    throw new ArgumentException("Unsupported browser");
            }
        }

    }
}
