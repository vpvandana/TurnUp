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
    [Parallelizable]
    public class TMtests : CommonDriver
    {
        Homepage hp = new Homepage();
        TMpage tm = new TMpage();

        

        [Test, Order (1)]
        public void CreateTimerecord_Test()
        {

            
            hp.Homesteps(driver);

            //Time and Material page initialization and defenition
            tm.CreateTimerecord(driver);
        }

        [Test, Order (2)]
        public void Edit_Test() 
        {
            hp.Homesteps(driver);
            tm.UpdateTimerec(driver);

        }


        [Test, Order (3)]
        public void Delete_Test()
        {
            hp.Homesteps(driver);
            tm.Deleterec(driver);

        }

       
    }
}
