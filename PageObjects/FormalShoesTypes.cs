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
    class FormalShoesTypes
    {
        public static IList<IWebElement> shoetype => PropertiesCollections.driver.FindElements(By.XPath("/html/body/div[2]/table/tbody/tr/td[1]"));
        public static IList<IWebElement> selection => PropertiesCollections.driver.FindElements(By.XPath("/html/body/div[2]/table/tbody/tr/td[1]/input"));
        public static IList<IWebElement> ShoeColour => PropertiesCollections.driver.FindElements(By.XPath("/html/body/div[2]/table/tbody/tr/td[3]/select"));
        public static IList<IWebElement> ShoeSize => PropertiesCollections.driver.FindElements(By.XPath("/html/body/div[2]/table/tbody/tr/td[4]/select"));
        public static IList<IWebElement> AddToCart => PropertiesCollections.driver.FindElements(By.XPath("/html/body/div[2]/table/tbody/tr/td[6]/button"));

        public static void  Add_Product_to_Cart()
        {
            Console.WriteLine(shoetype);
            for( int i =0; i< shoetype.Count; i++)
            {
                Console.WriteLine(i);
                if (shoetype.ElementAt(i).Text.Contains("Prestige"))
                {
                    selection.ElementAt(i).Click();
                    SelectElement drpShoeColour = new SelectElement(ShoeColour.ElementAt(i));
                    drpShoeColour.SelectByText(ConfigurationManager.AppSettings["ShoeColour"]);
                    SelectElement drpShoeSize = new SelectElement(ShoeSize.ElementAt(i));
                    drpShoeSize.SelectByText(ConfigurationManager.AppSettings["ShoeSize"]);
                    AddToCart.ElementAt(i).Click();
                }
            }
        }
    }
}
