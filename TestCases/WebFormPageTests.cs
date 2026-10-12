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
        private FormPage formPage;

        [SetUp] // Preparacion antes de correr los test
        public void Setup()
        {
            config = new ConfigReader();
            driver = DriverFactory.DriverFactory.CreateDriver(config.Browser);
            driver.Url = config.BaseUrl;
            driver.Manage().Window.Maximize();
            mainPage = new MainPage(driver);
            formPage = new FormPage(driver);
        }


        [Test] // cada metodo que va ser un test cases ocupa este tag
        public void testWebPageSimpleTest()
        {
            // Navigate to form page
            mainPage.goToForm();
            // Define implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Assert form title
            Assert.That(mainPage.validatePageTitle(), Is.EqualTo("Complete Web Form"));
            // Enter first Name
            formPage.addInputFirstName("Luis");
            // Enter last Name 
            formPage.addInputLastName("Bogantes");
            // Enter Job Title
            formPage.addInputJobTitle("Automation Engineer");
            // Check college radio bttn
            formPage.checkRadioCollege();
            // Check ckeck Box male 
            formPage.checkCheckBoxMale();
            // Select years of experience 
            formPage.selectExperience("2-4");
            // set date
            formPage.selectDate("10/13/2026");
            // Click on Submit
            formPage.clickSubmit();
            // Validate success message
            Assert.That(formPage.getSuccessMessage, Is.EqualTo("The form was successfully submitted!"));



        }


        [TearDown] // lo que vamos hacer despues de correr los test
        public void TearDown()
        {
            //driver.Quit();
            driver.Dispose();
        }

    }
}
