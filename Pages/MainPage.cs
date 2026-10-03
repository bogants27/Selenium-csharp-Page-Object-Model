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
    public class MainPage
    {
        private IWebDriver driver;
        
        private IWebElement linkWebForm;
        private IWebElement pageTitle;

        public MainPage(IWebDriver driver) { 
            this.driver = driver;
        
        }

        public void goToFormPage(){

            linkWebForm = this.driver.FindElement(By.XPath("/html/body/div/div/li[14]/a"));
            linkWebForm.Click();
        }

        public string validatePageTitle()
        {

            pageTitle = driver.FindElement(By.XPath("/html/body/div/h1"));

            return pageTitle.Text;
        }

    }
}
