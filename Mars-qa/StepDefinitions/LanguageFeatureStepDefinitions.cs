using Mars_qa.Page;
using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions :CommonDriver
    {
        [Given(@"User has successfullly logged into the Mar_qa Project")]
        public void GivenUserHasSuccessfulllyLoggedIntoTheMar_QaProject()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object identified and defined
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.loginsteps(driver);

        }

        [When(@"Create a language into user profile")]
        public void WhenCreateALanguageIntoUserProfile()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.addLanguage(driver);
            languagePageObj.languageInput(driver);
            languagePageObj.levelOption(driver);
            languagePageObj.createLanguage(driver);

        }

        [Then(@"Language have been Successfully Created")]
        public void ThenLanguageHaveBeenSuccessfullyCreated()
        {

            LanguagePage languagePageObj = new LanguagePage();
            string newLanguage = languagePageObj.GetVerifyLanguageCreation(driver);

            Assert.AreEqual("Tamil", newLanguage, "Actual Language and expected Language do not match");



        }
    }
}
