using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TurnUp.Pages;
using TurnUp.Utilities;

namespace TurnUp.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"Launch TurnUp portal and login with valid credentials")]
        public void GivenLaunchTurnUpPortalAndLoginWithValidCredentials()
        {
            driver = new ChromeDriver();
            Loginpage loginpageobject = new Loginpage();
            loginpageobject.Loginsteps(driver);
            
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            Homepage homepageobject = new Homepage();
            homepageobject.GoToTMpage(driver);
        }

        [When(@"I create new time and materials record")]
        public void WhenICreateNewTimeAndMaterialsRecord()
        {
           TMpage tmpageobject = new TMpage();
           tmpageobject.CreateTimerecord(driver);
        }

        [Then(@"new time and material record created successfully")]
        public void ThenNewTimeAndMaterialRecordCreatedSuccessfully()
        {
            TMpage tmpageobject = new TMpage();
            string newCode = tmpageobject.GetCode(driver);
            string newDescription = tmpageobject.GetDescription(driver);
            string newPrice = tmpageobject.GetPrice(driver);

            Assert.AreEqual("May2023", newCode, "Actual code and expexted code do not match");
            Assert.AreEqual("May2023", newDescription, "Actual description and expected description do not match");
            Assert.AreEqual("$13.00", newPrice, "Actual price and expexted price do not match");
        }

        
        [When(@"I update existing time and materials '([^']*)','([^']*)' and '([^']*)' record")]
        public void WhenIUpdateExistingTimeAndMaterialsAndRecord(string description, string code, string price)
        {
            TMpage tmpageobject = new TMpage();
            tmpageobject.EditTM(driver, description, code,  price);
        }

        [Then(@"The record has been updated '([^']*)' , '([^']*)' and '([^']*)'")]
        public void ThenTheRecordHasBeenUpdatedAnd(string description, string code, string price)
        {
            TMpage tmpageobject = new TMpage();
            string editedDescription = tmpageobject.GetEditedDescription(driver);
            string editedCode = tmpageobject.GetEditedCode(driver);
            string editedPrice = tmpageobject.GetEditedPrice(driver);
            Assert.AreEqual(editedDescription, description, "The actual description and edited description does not match");
            Assert.AreEqual(editedCode, code , "The actual code and edited code does not match");
            Assert.AreEqual(editedPrice, price, "The actual price and edited price does not match");
        }

    }


}

