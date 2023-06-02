﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp.Utilities;
using NUnit.Framework;

namespace TurnUp.Pages
{
    public class TMpage : CommonDriver
    {
        public void CreateTimerecord(IWebDriver driver)
        {
            //------------------CREATE NEW RECORD-------------------

            //Click on create new btton
            IWebElement Createnewbtn = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            Createnewbtn.Click();
            Thread.Sleep(3000);

            //Click Time from Typecode dropdown list
            IWebElement TypeCodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            TypeCodedropdown.Click();
            Thread.Sleep(2000);
            IWebElement Timetypecode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            Timetypecode.Click();
            
            Thread.Sleep(3000);

            //input code
            IWebElement inputTxtbox = driver.FindElement(By.Id("Code"));
            inputTxtbox.SendKeys("May 2023");

            //input description
            IWebElement descptiontxtbox = driver.FindElement(By.Id("Description"));
            descptiontxtbox.SendKeys("May 2023");
            Thread.Sleep(2000);

            //input price
            IWebElement pricetxtbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricetxtbox.SendKeys("13");
            Thread.Sleep(2000);

            //click on save button
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            Thread.Sleep(3000);

            //Check if new record is created

            //Go to last page by clicking last page button as new record is added at the last
            //IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastPageButton.Click();
            //Thread.Sleep(2000);

            //Check if last row rec is same as the created record
            //IWebElement lastrowrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
           
           
           // Assert.That(lastrowrecord.Text == "May 2023", "The record is not created!");


        }
        public string GetCode(IWebDriver driver) 
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver) 
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text; 
         
        }

        public string GetPrice(IWebDriver driver) 
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }
        //-------------------EDIT A TIME RECORD----------------------
        public void EditTM(IWebDriver driver , string description)
        {

            //Click on edit button

            //Goto last page
            //Click on lastpage button
            IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            Thread.Sleep(2000);
            lastpagebutton.Click();

            IWebElement lastrowrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
          
            if (lastrowrecord.Text == "May 2023")
            {
                IWebElement Editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
               // Thread.Sleep(2000);
                Editbtn.Click();
                Thread.Sleep(3000);
            }

            else
            {
                Assert.Fail("The new record created is not found !");
            }

            //Edit Code
            IWebElement codetxtboxedit = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codetxtboxedit.Clear();
            //Thread.Sleep(1000);
            codetxtboxedit.SendKeys("June2023");
            Thread.Sleep(1000);

            //Edit Description
            IWebElement descriptiontxtboxedit = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            descriptiontxtboxedit.Clear();
            descriptiontxtboxedit.SendKeys(description);
            Thread.Sleep(3000);

            //Edit Price

            //overlapping tag
            
            
                IWebElement editOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
                editOverlap.Clear();
            
            

            //For actual tag

            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();

            editOverlap.SendKeys("30");
            Thread.Sleep(2000);

            //Click on Save button
            IWebElement Savebtn = driver.FindElement(By.Id("SaveButton"));
            Savebtn.Click();
            Thread.Sleep(1000);

           /* IWebElement lastcreatedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if(lastcreatedrecord.Text == "May 2023")
            {
                IWebElement Savebtn = driver.FindElement(By.Id("SaveButton"));
                Savebtn.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Assert.Fail("New record created has'nt found!");
            }*/
            

            //Check if last last row record is same as the edited record

            //Go to the last page
            IWebElement lastpagebutton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            Thread.Sleep(1000);
            lastpagebutton1.Click();

            Thread.Sleep(2000);

            //Check if new code is edited

            
           

           /* IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            Assert.That(editedDescription.Text == "June2023", "The description is not edited");

            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            Assert.That(editedPrice.Text == "30", "Price not edited");*/

        }
        public string GetEditedDescription(IWebDriver driver , string description)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }

            //--------------------TO DELETE A RECORD----------------------
            public void Deleterec(IWebDriver driver) 
            {

            //Go to last page
            IWebElement lastpagebutton2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpagebutton2.Click();

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

            //Check if record is deleted

            //Go to last page
            IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpagebutton.Click();

            //Check if last record is not June2023
            IWebElement lastrowrec = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastrowrec.Text != "June2023", "The last record not deleted !");



        }
    }
}
