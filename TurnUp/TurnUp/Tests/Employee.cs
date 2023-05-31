using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp.Pages;
using TurnUp.Utilities;

namespace TurnUp.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee : CommonDriver
    {
        Homepage hp = new Homepage();
        Employeepage Ep = new Employeepage();






        [Test]
        public void Create_Employee()
        {
            hp.HomeEmployee(driver);
            
            Ep.Create_Employee(driver);


        
        }

        [Test]
        public  void edit_Employee()
        {
            hp.HomeEmployee(driver);
            Ep.Update_Employee(driver);
        }
        [Test]
        public void delete_Employee()
        {
           
            hp.HomeEmployee(driver);
            Ep.Delete_Employee(driver);
        }
       
    }
}
