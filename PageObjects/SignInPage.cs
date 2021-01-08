using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoePortal.PageObjects
{
    class SignInPage
    {
        public static int txtuserlength => PropertiesCollections.driver.FindElements(By.Id("usr")).Count;
        public static int txtpwdlength => PropertiesCollections.driver.FindElements(By.Id("pwd")).Count;
        public static int btnLogin => PropertiesCollections.driver.FindElements(By.XPath("//input[@value='Login']")).Count;
        public static int btnRegistration => PropertiesCollections.driver.FindElements(By.Id("NewRegistration")).Count;

        public static IWebElement btnNewRegistration => PropertiesCollections.driver.FindElement(By.Id("NewRegistration"));
        public static IWebElement btnLgn => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"second_form\"]/input"));
        public static IWebElement txtUserName => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"usr\"]"));
        public static IWebElement txtPassword => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"pwd\"]"));
        public static string txtUsrPwdErrorMsg => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"second_form\"]/div[2]/span")).Text;

        public static void clickNewRegistration()
        {
            btnNewRegistration.Click();
        }

        public static void clickLogin()
        {
            btnLgn.Click();
        }

        public static void enterUserName()
        {
            txtUserName.SendKeys(ConfigurationManager.AppSettings["Username"]);
        }
        public static void enterPassword()
        {
            txtPassword.SendKeys(ConfigurationManager.AppSettings["Password"]);
        }
    }
}
