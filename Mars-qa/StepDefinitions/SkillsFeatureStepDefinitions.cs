using Mars_qa.Page;
using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions :CommonDriver

    {
        [Given(@"User has successfully logged into the Mar_qa application")]
        public void GivenUserHasSuccessfullyLoggedIntoTheMar_QaApplication()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object identified and defined
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.loginsteps(driver);

        }

        [When(@"Create skills in the user profile")]
        public void WhenCreateSkillsInTheUserProfile()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.addSkills(driver);
            skillsPageObj.skillsInput(driver);
            skillsPageObj.skillslevelOption(driver);
            skillsPageObj.createSkills(driver);

        }

        [Then(@"Skills have been Successfully Created")]
        public void ThenSkillsHaveBeenSuccessfullyCreated()
        {
            SkillsPage skillspageObj = new SkillsPage();
            string newSkills = skillspageObj.GetverifyskillsCreation(driver);
            Assert.AreEqual("C#", newSkills, "ActuaSkills  and expected skills do not match");

        }
    }
}
