using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUp.Pages
{
    public class TMpage
    {
        public void CreateTimerec(IWebDriver driver)
        {
            //------------------CREATE NEW RECORD-------------------

            //Click on create new btton
            IWebElement Createnewbtn = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            Createnewbtn.Click();

            //Click Time from Typecode dropdown list
            IWebElement TypeCodedrpdwn = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            TypeCodedrpdwn.Click();

            //input code
            IWebElement inputTxtbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            inputTxtbox.SendKeys("May 2023");

            //input description
            IWebElement descptiontxtbox = driver.FindElement(By.Id("Description"));
            descptiontxtbox.SendKeys("May 2023");
            Thread.Sleep(3000);

            //input price
            IWebElement pricetxtbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricetxtbox.SendKeys("13");
            Thread.Sleep(2000);

            //click on save button
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            Thread.Sleep(3000);
        }

        //-------------------EDIT A TIME RECORD----------------------
        public void UpdateTimerec(IWebDriver driver)
        {

            //Click on edit button
            IWebElement Editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(2000);
            Editbtn.Click();
            Thread.Sleep(3000);

            //Edit Code
            IWebElement codetxtboxedit = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codetxtboxedit.Clear();
            Thread.Sleep(1000);
            codetxtboxedit.SendKeys("June2023");
            Thread.Sleep(3000);

            //Edit Description
            IWebElement descriptiontxtboxedit = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            descriptiontxtboxedit.Clear();
            descriptiontxtboxedit.SendKeys("June2023");
            Thread.Sleep(3000);

            //Edit Price
            IWebElement pricetxtboxedit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //pricetxtboxedit.Clear();
            pricetxtboxedit.SendKeys("30");
            Thread.Sleep(2000);

            //Click on Save button
            IWebElement Savebtn = driver.FindElement(By.Id("SaveButton"));
            Savebtn.Click();
            Thread.Sleep(1000);
        }

            //--------------------TO DELETE A RECORD----------------------
            public void Deleterec(IWebDriver driver) 
            { 

            //click on delete button
             IWebElement deletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
             deletebtn.Click();

            //click on OK button in the popup menu
            Thread.Sleep(3000);
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept();
            // Console.WriteLine("First record deleted !");
            Thread.Sleep(2000);


            }
    }
}
