using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WorkTask
{
    class SeleniumSetClass
    {
        //Quick use of methods (Driver, name of the element(Id,Name), text we want to put in the textbox, type of the element)
        public static void ElementText(IWebDriver driver, string element, string value, string elementType)
        {
            //Searching the element by (Id, Name or Xpath) and inputing the value...
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "XPath")
                driver.FindElement(By.XPath(element)).SendKeys(value);
        }
        //Quick use of methods (Driver, name of the element(Id,Name), type of the element)
        public static void ElementClick(IWebDriver driver, string element, string elementType)
        {
            //Searching the element by (Id, Name or Xpath) and clicking it...
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementType == "XPath")
                driver.FindElement(By.XPath(element)).Click();
        }

    }
}
