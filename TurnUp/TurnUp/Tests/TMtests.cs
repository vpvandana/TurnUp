using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp.Pages;
using TurnUp.Utilities;
using OpenQA.Selenium.Safari;
using NUnit.Framework;

namespace TurnUp.Tests
{
    [TestFixture]
    public class TMtests: CommonDriver
    {

        [SetUp] 
         public void Setup()
        {
            
            //Launch chrome browser

            driver = new ChromeDriver();    

           //Login page object initialization and defenition
            Loginpage lp = new Loginpage();
            lp.Loginsteps(driver);

            //Home page object initialization and defenition
            Homepage hp = new Homepage();
            hp.Homesteps(driver);


        }

        [Test]
        public void CreateTimerecord_Test()
        {
           
            //Time and Material page initialization and defenition

            TMpage tm = new TMpage();
            tm.CreateTimerecord(driver);
        }

        [Test]
        public void Edit_Test() 
        {
            TMpage tm = new TMpage();
            tm.UpdateTimerec(driver);

        }


        [Test]
        public void Delete_Test()
        {
            TMpage tm = new TMpage();
            tm.Deleterec(driver);

        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
        
        
        
       
       
    }
}
