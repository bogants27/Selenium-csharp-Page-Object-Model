using AutomationFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AutomationPracticeNUnit.Pages
{
    internal class FormPage
    {
        private IWebDriver driver;
        private IWebElement inputFirstName;
        private IWebElement inputLastName;
        private IWebElement inputJobTitle;

        private IWebElement radioCollege;

        private IWebElement checkBoxMale;

        private IWebElement dropDownExperience;

        private IWebElement datePicker;

        private IWebElement btnSubmit;

        private IWebElement successMessage;

        public FormPage(IWebDriver driver) { 
        
            this.driver = driver;
        
        }


        public void addInputFirstName(string firstName) {

            inputFirstName = this.driver.FindElement(By.Id("first-name"));
            inputFirstName.SendKeys(firstName);
        
        
        }


        public void addInputLastName(string lastName)
        {

            inputLastName = this.driver.FindElement(By.Id("last-name"));
            inputLastName.SendKeys(lastName);


        }

        public void addInputJobTitle(string jobTitle)
        {

            inputJobTitle = this.driver.FindElement(By.Id("job-title"));
            inputJobTitle.SendKeys(jobTitle);


        }

        public void checkRadioCollege() {

            radioCollege = this.driver.FindElement(By.Id("radio-button-2"));
            radioCollege.Click();
        
        }

        public void checkCheckBoxMale() {
            checkBoxMale = this.driver.FindElement(By.Id("checkbox-1"));
        
        }

        public void selectExperience(string yearsRange) {
            dropDownExperience = driver.FindElement(By.Id("select-menu"));
            dropDownExperience.SendKeys(yearsRange);
        
        }


        public void selectDate(string date) {
            datePicker = driver.FindElement(By.Id("datepicker"));
            datePicker.SendKeys(date);


        }

        public void clickSubmit() {
            btnSubmit = driver.FindElement(By.ClassName("btn-primary"));
            btnSubmit.Click();
        }


        public string getSuccessMessage() {
            successMessage = driver.FindElement(By.ClassName("alert-success"));
            return successMessage.Text;
        
        }


    }
}
