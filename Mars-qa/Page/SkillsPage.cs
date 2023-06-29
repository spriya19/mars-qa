﻿using Mars_qa.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            Wait.WaitToBeExists(driver, "XPath", "//div[@class='ui teal button']", 7);

            IWebElement addnewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addnewButton.Click();

        }
        public void inputKeys1(IWebDriver driver)
        {
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys("API");
            Thread.Sleep(2000);
            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.SendKeys("Intermediate");
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(3000);
        }
        public void inputKeys2(IWebDriver driver)
        {
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnewButton = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnewButton.Click();
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys("Java");
            Thread.Sleep(2000);
            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.SendKeys("Beginner");
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(3000);
        }
        public string getInputKey1(IWebDriver driver)
        {
            IWebElement skill1Textbox = driver.FindElement(By.XPath("//td[normalize-space()='API']"));
            return skill1Textbox.Text;

        }
        public string getInputKey2(IWebDriver driver)
        {
            IWebElement skill2Textbox = driver.FindElement(By.XPath("//td[normalize-space()='Java']"));
            return skill2Textbox.Text;
        }
        public void editSkillInput(IWebDriver driver, string skill, string level)
        {
            //select skillstab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsTab.Click();
            Thread.Sleep(2000);

            //Click the edit Icon
            IWebElement editIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            editIcon.Click();

            IWebElement editSkillInput = driver.FindElement(By.Name("name"));
            editSkillInput.Clear();
            editSkillInput.SendKeys(skill);
            IWebElement editlevelOption = driver.FindElement(By.Name("level"));
            editlevelOption.SendKeys(level);
            IWebElement updateLanguages = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateLanguages.Click();
            Thread.Sleep(3000);
        }
        public string GeteditSkillInput(IWebDriver driver)
        {
            IWebElement editSkillInput = driver.FindElement(By.XPath("//td[normalize-space()='API']"));
            return editSkillInput.Text;
        }
        public string GeteditlevelOption(IWebDriver driver)
        {
            IWebElement editlevelOption = driver.FindElement(By.XPath("//td[normalize-space()='Intermediate']"));
            return editlevelOption.Text;
        }
        public void deleteSkill(IWebDriver driver)
        {
            //select skillstab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsTab.Click();
            Thread.Sleep(2000);

            IWebElement deleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteIcon.Click();
        }
        public string getDeleteSkill(IWebDriver driver)
        {
            IWebElement deletedInput = driver.FindElement(By.XPath("//td[normalize-space()='API']"));
            return deletedInput.Text;
        }
        public string getDeleteLevel(IWebDriver driver)
        {
            IWebElement deleteOption = driver.FindElement(By.XPath("//td[normalize-space()='Intermediate']"));
            return deleteOption.Text;
        }

    }
}
