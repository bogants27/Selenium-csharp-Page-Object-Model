using AutomationFramework.Utilities;
using AutomationPracticeNUnit.DriverFactory;
using AutomationPracticeNUnit.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;



namespace AutomationPracticeNUnit.TestCases
{
    [TestFixture] // indica que la clase va tener tests
    public class WebFormPageTests
    {

        private IWebDriver driver;
        private MainPage  mainPage;
        private ConfigReader config;

        [SetUp]
        public void Setup()
        {
            config = new ConfigReader();
            driver = DriverFactory.DriverFactory.CreateDriver(config.Browser);
            driver.Url = config.BaseUrl;
            driver.Manage().Window.Maximize();
            mainPage = new MainPage(driver);
        }


        [Test] // cada metodo que va ser un test cases ocupa este tag
        public void testWebPageSimpleTest()
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            mainPage.goToFormPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            //mainPage = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("successMsg")));
            Assert.That(mainPage.validatePageTitle(), Is.EqualTo("Complete Web Form"));
        }


        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
            driver.Dispose();
        }

    }
}
