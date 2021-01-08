using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoePortal.PageObjects
{
    class RegistrationPage
    {
        public static IWebElement btnSubmit => PropertiesCollections.driver.FindElement(By.XPath("//input[@value='Submit']"));
        public static IWebElement txtFirstName => PropertiesCollections.driver.FindElement(By.Id("firstname"));
        public static IWebElement txtLastName => PropertiesCollections.driver.FindElement(By.Id("lastname"));
        public static IWebElement txtEmailid => PropertiesCollections.driver.FindElement(By.Id("emailId"));
        public static IWebElement txtUsername => PropertiesCollections.driver.FindElement(By.Id("usr"));
        public static IWebElement txtPassword => PropertiesCollections.driver.FindElement(By.Id("pwd"));
        public static string txtErrorMsg => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"first_form\"]/div/span")).Text;
        public static string txtErrorMsg2 => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"first_form\"]/div/span")).Text;

        public static void select_Salutation()
        {
            SelectElement drpSalutation = new SelectElement(PropertiesCollections.driver.FindElement(By.Id("Salutation")));
            drpSalutation.SelectByText(ConfigurationManager.AppSettings["Salutation"]);
        }

        public static void click_Submit()
        {
            btnSubmit.Click();
        }
        public static void enter_FirstName()
        {
            txtFirstName.SendKeys(ConfigurationManager.AppSettings["FirstName"]);
        }
        public static void enter_LastName()
        {
            txtLastName.SendKeys(ConfigurationManager.AppSettings["LastName"]);
        }
        public static void enter_InvalidEmail()
        {
            txtEmailid.SendKeys(ConfigurationManager.AppSettings["InvalidEmailAddress"]);
        }
        public static void enter_ValidEmail()
        {
            txtEmailid.SendKeys(ConfigurationManager.AppSettings["ValidEmailAddress"]);
        }
        public static void enter_UsrName()
        {
            txtUsername.SendKeys(ConfigurationManager.AppSettings["Username"]);
        }
        public static void enter_Password()
        {
            txtPassword.SendKeys(ConfigurationManager.AppSettings["Password"]);
        }

    }
}
