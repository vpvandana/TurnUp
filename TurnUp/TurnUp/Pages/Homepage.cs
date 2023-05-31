using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp.Utilities;
using NUnit.Framework;

namespace TurnUp.Pages
{
    public class Homepage : CommonDriver 
    {
        public void Homesteps(IWebDriver driver)
        {
           // Navigate to Administration

            IWebElement Administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationtab.Click();
            Thread.Sleep(1000);

            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a", 7);

            //Click on Time and Materials module

            IWebElement Tandmbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
            Tandmbtn.Click();
            Thread.Sleep(3000);
        }
        public void HomeEmployee(IWebDriver driver) 
        {
            //Navigate to Admin tab

            IWebElement Administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationtab.Click();
            Thread.Sleep(1000);

            //Click on Employee module
            IWebElement Employeebutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employeebutton.Click();
            Thread.Sleep(3000);
        }
    }
}
