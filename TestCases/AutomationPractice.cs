using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeNUnit.TestCases
{
    [TestFixture] // indica que la clase va tener tests
    public class AutomationPractice
    {
        [Test] // cada metodo que va ser un test cases ocupa este tag
        public void testWebPageSimpleTest()
        {

            var driver = new ChromeDriver();
            driver.Url = "https://curso.testautomation.es";
            driver.Manage().Window.Maximize();
            var normalLink = driver.FindElement(By.Id("NormalWeb"));
            normalLink.Click();
            var normalWebTitle = driver.FindElement(By.XPath("/html/body/h1"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            /*wait.Until(driver => 
            {
                return driver.FindElement(By.XPath("/html/body/h1")).Text.Equals("Normal load website");
            });*/
            //normalWebTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("miElemento")));
            //normalWebTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/h1")));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            normalWebTitle.Text.Equals("Normal load website");
            var backToMain = driver.FindElement(By.XPath("/html/body/a"));
            backToMain.Click();
            driver.Quit();
        }

        [Test] // cada metodo que va ser un test cases ocupa este tag
        public void testWebPageFruits()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://curso.testautomation.es";
            driver.Manage().Window.Maximize();
            var linkFruits = driver.FindElement(By.Id("FruitVegetablesShop"));
            linkFruits.Click();
            // Add apple to cart
            var inputApple = driver.FindElement(By.Id("appleQuantity"));
            inputApple.Clear();
            inputApple.SendKeys("2");
            var btnAddApple = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/button"));
            btnAddApple.Click();
            var btnCart = driver.FindElement(By.Id("cart-icon"));
            btnCart.Click();
            var btnCloseCart = driver.FindElement(By.Id("CloseCart"));
            btnCloseCart.Click();
            // Add Banana and remove it from the cart
            var inputBanana = driver.FindElement(By.Id("bananaQuantity"));
            inputBanana.SendKeys("3");
            btnCart.Click();
            var btnRemove = driver.FindElement(By.XPath("//*[@id=\"cart\"]/div/button"));
            btnRemove.Click();
            btnCloseCart.Click();
            driver.Quit();

        }

    }
}
