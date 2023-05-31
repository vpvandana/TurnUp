using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TurnUp.Pages;

namespace TurnUp.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Loginsteps()

        {
            //Lauch Chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and defenition
            Loginpage lp = new Loginpage();
            lp.Loginsteps(driver);
        }

        [OneTimeTearDown]


    public void LoginstepsTearDown() 
        {
            driver.Quit();
        
        }
    }
}
