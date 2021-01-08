using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoePortal.PageObjects
{
    class HomePage
    {
        public static IWebElement menu_input => PropertiesCollections.driver.FindElement(By.CssSelector("#menuToggle > input[type=checkbox]"));
        public static IWebElement lnkSignInPortal => PropertiesCollections.driver.FindElement(By.LinkText("Sign In Portal"));
        public static void click_SignInPortal()
        {
            menu_input.Click();
            PropertiesCollections.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            lnkSignInPortal.Click();
        }
    }
}
