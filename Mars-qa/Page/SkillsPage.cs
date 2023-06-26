using Mars_qa.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_qa.Page
{
    public class SkillsPage : CommonDriver      
    {
        public void addSkills(IWebDriver driver)
        {
            //create new record
            //select skillstab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsTab.Click();
            Thread.Sleep(2000);                                    
            
            IWebElement addnewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addnewButton.Click();

        }
        public void skillsInput(IWebDriver driver)
        {
            //Generate random values in skillsfield
            Random random = new Random();
            string[] skills = { "C#", "Specflow","API","Selenium","JMeter" };
            //int index = random.Next(languages.Length);
            int index = random.Next(0, skills.Length);
            string randomSkills = skills[index];

            //Enter the language input
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys(randomSkills);
            Thread.Sleep(2000);
        }
        public void skillslevelOption(IWebDriver driver) 
        {
            //Select the level option
            //Generate random values in skillsfield
            Random random = new Random();
            string[] skillslevelOption = { "Basic", "Cnversational", "Fluent", "Native/Billingual" };
            //int index = random.Next(languages.Length);
            int index = random.Next(skillslevelOption.Length);
            string randomLevel = skillslevelOption[index];
            IWebElement skillsLevelDropdown = driver.FindElement(By.Name("level"));
           skillsLevelDropdown.SendKeys(randomLevel);
        }
        public void createSkills(IWebDriver driver)
        {
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(3000);
        }
        public string GetverifyskillsCreation(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;

        }

    }
}
