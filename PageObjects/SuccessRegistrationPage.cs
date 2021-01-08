using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoePortal.PageObjects
{
    class SuccessRegistrationPage
    {

        public static string SuccessMsg => PropertiesCollections.driver.FindElement(By.XPath("/html/body/center[1]/h1")).Text;
    }
}
