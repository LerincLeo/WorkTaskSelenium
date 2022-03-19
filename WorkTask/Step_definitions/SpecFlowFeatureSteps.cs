using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WorkTask
{
    [Binding]
    class SpecFlowFeatureSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Navigate to the Swag Labs LogIn page")]
        public void GivenNavigateToTheSwagLabsLogInPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Then(@"LogIn button is clicked Error message should apper")]
        public void ThenLogInButtonIsClickedErrorMessageShouldApper()
        {
            SeleniumSetClass.ElementClick(driver, "//input[@id='login-button']", "XPath");
        }

        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Close();
        }

        [Then(@"Input wrong_user in thextbox Username")]
        public void ThenInputWrong_UserInThextboxUsername()
        {
            SeleniumSetClass.ElementText(driver, "//input[@id='user-name']", "wrong_user", "XPath");
        }

        [Then(@"Input bad_sauce in textbox Password")]
        public void ThenInputBad_SauceInTextboxPassword()
        {
            SeleniumSetClass.ElementText(driver, "//input[@id='password']", "bad_sauce", "XPath");
        }

        [Then(@"Input standard_user in thextbox Username")]
        public void ThenInputStandard_UserInThextboxUsername()
        {
            SeleniumSetClass.ElementText(driver, "//input[@id='user-name']", "standard_user", "XPath");
        }

        [Then(@"Input secret_sauce in textbox Password")]
        public void ThenInputSecret_SauceInTextboxPassword()
        {
            SeleniumSetClass.ElementText(driver, "//input[@id='password']", "secret_sauce", "XPath");
        }

        [Then(@"LogIn button is clicked and Swag Labs Home Page appears")]
        public void ThenLogInButtonIsClickedAndSwagLabsHomePageAppears()
        {
            SeleniumSetClass.ElementClick(driver, "//input[@id='login-button']", "XPath");
        }

        [Then(@"Should add Sauce Labs Backpack to cart")]
        public void ThenShouldAddSauceLabsBackpackToCart()
        {
            SeleniumSetClass.ElementClick(driver, "//button[@id='add-to-cart-sauce-labs-backpack']", "XPath");
        }

        [Then(@"Should add Sauce Labs Fleece Jacket to cart")]
        public void ThenShouldAddSauceLabsFleeceJacketToCart()
        {
            SeleniumSetClass.ElementClick(driver, "//button[@id='add-to-cart-sauce-labs-fleece-jacket']", "XPath");
        }
        [Then(@"Click on Shopping cart should open Your cart with products")]
        public void ThenClickOnShoppingCartShouldOpenYourCartWithProducts()
        {
            SeleniumSetClass.ElementClick(driver, "//a[@class='shopping_cart_link']", "XPath");
        }

        [When(@"Click on Checkout button should Checkout informations page open")]
        public void WhenClickOnCheckoutButtonShouldCheckoutInformationsPageOpen()
        {
            SeleniumSetClass.ElementClick(driver, "//button[@id='checkout']", "XPath");
        }

        [When(@"Input secret in textbox First Name")]
        public void WhenInputSecretInTextboxFirstName()
        {
            SeleniumSetClass.ElementText(driver, "//input[@name='firstName']", "secret", "XPath");
        }

        [When(@"Input sauce in textbox Last Name")]
        public void WhenInputSauceInTextboxLastName()
        {
            SeleniumSetClass.ElementText(driver, "//input[@name='lastName']", "sauce", "XPath");
        }

        [When(@"Input (.*) in thextbox Zip/Postal Code")]
        public void WhenInputInThextboxZipPostalCode(int p0)
        {
            SeleniumSetClass.ElementText(driver, "//input[@name='postalCode']", "32351", "XPath");
        }

        [When(@"Click on Checkout button should Overview page open")]
        public void WhenClickOnCheckoutButtonShouldOverviewPageOpen()
        {
            SeleniumSetClass.ElementClick(driver, "//input[@name='continue']", "XPath");
        }

        [When(@"Click on Finish button should Checkout:Complete! page open")]
        public void WhenClickOnFinishButtonShouldCheckoutCompletePageOpen()
        {
            SeleniumSetClass.ElementClick(driver, "//button[@name='finish']", "XPath");
        }

        [Then(@"Click Back Home button should open Home Page with products")]
        public void ThenClickBackHomeButtonShouldOpenHomePageWithProducts()
        {
            SeleniumSetClass.ElementClick(driver, "//button[@name='back-to-products']", "XPath");
        }

    }
}
