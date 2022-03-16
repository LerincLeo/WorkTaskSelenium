using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace WorkTask
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void BrowserCheckup()
        {
            //Open the Chrome browser and go to selected site...
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }        
        [Test,Category("Clear")]
        public void ClearLogIn()
        {
            //Clicking the login button.
            SeleniumSetClass.ElementClick(driver, "//input[@id='login-button']", "XPath");
        }
        [Test, Category("Wrong")]
        public void WrongUser()
        {   //Entering a wrong username.
            SeleniumSetClass.ElementText(driver, "//input[@id='user-name']", "wrong_user", "XPath");
            //Entering a wrong password.
            SeleniumSetClass.ElementText(driver, "//input[@id='password']", "bad_sauce", "XPath");
            //Clicking the login button.
            SeleniumSetClass.ElementClick(driver, "//input[@id='login-button']", "XPath");
        }
        [Test, Category("Correct")]
        public void LogInWithUser()
        {   //Entering a correct username.
            SeleniumSetClass.ElementText(driver, "//input[@id='user-name']", "standard_user", "XPath");
            //Entering a correct password.
            SeleniumSetClass.ElementText(driver, "//input[@id='password']", "secret_sauce", "XPath");
            //Clicking the login button.
            SeleniumSetClass.ElementClick(driver, "//input[@id='login-button']", "XPath");        
            //add to cart Sauce Labs Backpack
            SeleniumSetClass.ElementClick(driver, "//button[@id='add-to-cart-sauce-labs-backpack']", "XPath");
            //add to cart Sauce Labs Fleece Jacket
            SeleniumSetClass.ElementClick(driver, "//button[@id='add-to-cart-sauce-labs-fleece-jacket']", "XPath");
            //go for the checkout
            SeleniumSetClass.ElementClick(driver, "//a[@class='shopping_cart_link']", "XPath");
            SeleniumSetClass.ElementClick(driver, "//button[@id='checkout']", "XPath");
            //input neccesary things
            SeleniumSetClass.ElementText(driver, "//input[@name='firstName']", "secret", "XPath");
            SeleniumSetClass.ElementText(driver, "//input[@name='lastName']", "sauce", "XPath");
            SeleniumSetClass.ElementText(driver, "//input[@name='postalCode']", "32351", "XPath");
            //proceed to payment
            SeleniumSetClass.ElementClick(driver, "//input[@name='continue']", "XPath");
            //payment complete
            SeleniumSetClass.ElementClick(driver, "//button[@name='finish']", "XPath");
            //go back to homepage with products
            SeleniumSetClass.ElementClick(driver, "//button[@name='back-to-products']", "XPath");
        }
        [TearDown]
        public void BrowserCleanup()
        {
            Thread.Sleep(3000);
            //Closing the program...
            driver.Close();
        }
    }
}
