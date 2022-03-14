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
            SeleniumSetClass.ElementClick(driver, "//*[@id='login-button']", "XPath");
        }
        [Test, Category("Wrong")]
        public void WrongUser()
        {   //Entering a wrong username.
            SeleniumSetClass.ElementText(driver, "//*[@id='user-name']", "wrong_user", "XPath");
            //Entering a wrong password.
            SeleniumSetClass.ElementText(driver, "//*[@id='password']", "bad_sauce", "XPath");
            //Clicking the login button.
            SeleniumSetClass.ElementClick(driver, "//*[@id='login-button']", "XPath");
        }
        [Test, Category("Correct")]
        public void LogInWithUser()
        {   //Entering a correct username.
            SeleniumSetClass.ElementText(driver, "//*[@id='user-name']", "standard_user", "XPath");
            //Entering a correct password.
            SeleniumSetClass.ElementText(driver, "//*[@id='password']", "secret_sauce", "XPath");
            //Clicking the login button.
            SeleniumSetClass.ElementClick(driver, "//*[@id='login-button']", "XPath");
        }
        [TearDown]
        public void BrowserCleanup()
        {   
            //Closing the program...
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
