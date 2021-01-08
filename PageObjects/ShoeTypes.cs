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
    class ShoeTypes
    {
        public static int txtFormalShoeType => PropertiesCollections.driver.FindElements(By.XPath("//*[contains(text(), 'Formal Shoes')]")).Count;
        public static int txtSportsShoeType => PropertiesCollections.driver.FindElements(By.XPath("//*[contains(text(), 'Sports')]")).Count;
        public static int txtSneakersShoeType => PropertiesCollections.driver.FindElements(By.XPath("//*[contains(text(), 'Sneakers')]")).Count;

        public static IWebElement btnFormalShoeCollection => PropertiesCollections.driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/button"));
        
        public static void clickFormalShoeCollection()
        {
            btnFormalShoeCollection.Click();
        }
    }
}
