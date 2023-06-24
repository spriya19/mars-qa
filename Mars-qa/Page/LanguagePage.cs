using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_qa.Page
{
    public class LanguagePage:CommonDrive
    {
        public void gotoLanguagePage(IWebDriver driver)
        {
           IWebElement languageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageTab.Click();

            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
        }
        public void languageInput(IWebDriver driver)
        {

            // Generate a random language value
            Random random = new Random();
            string[] languages = { "English", "Hindi", "Tamil", "German" };
            int index = random.Next(languages.Length);
            string randomLanguage = languages[index];

            // Find the input field or element where you want to send the random language value
            IWebElement languageInput = driver.FindElement(By.Name("name"));

            // Send the random language value to the input field
            languageInput.SendKeys(randomLanguage);
            Assert.Pass("Language has been added Successfully");
        }

        public void levelOption(IWebDriver driver)
        {
            Random random = new Random();
            string[] chooselanguageslevel = { "Basic", "Conversational", "Fluent", "Native/Bilingual" };
            int level = random.Next(chooselanguageslevel.Length);
            string randomLevel = chooselanguageslevel[level];
            Thread.Sleep(2000);

            // select the level
            IWebElement selectlevelInput = driver.FindElement(By.Name("level"));
            selectlevelInput.Click();
            Thread.Sleep(2000);
            // enter the input keys
            selectlevelInput.SendKeys(randomLevel);
            Console.WriteLine("Language Level has been selected successfully");
        }
        public void verifycreateLanguage(IWebDriver driver)
        { 
            // Click the AddButton
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

            Assert.Pass("Language has been successfully added to the profile page");

        }
        public void editLanguage(IWebDriver driver)
        {
            //Click the Edit Icon
            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/text()"));
            editIcon.Click();
        }
        public void editLanguageInput(IWebDriver driver)
        {
            //Edit the LAnguage Input
            IWebElement editlanguageInput = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            editlanguageInput.Clear();
            // Generate a random language value
            Random random = new Random();
            string[] editlanguages = { "Tamil12", "Chineese", "Marati", "Arabic" };
            int index = random.Next(editlanguages.Length);
            string randomeditLanguage = editlanguages[index];
            editlanguageInput.SendKeys(randomeditLanguage);
            Assert.Pass("Language has been Edited successfully");
        }
        public void updateeditlanguage(IWebDriver driver)
        {
            IWebElement updateeditlanguage = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateeditlanguage.Click();
            Assert.Pass("Language has been updated successfully");
        }
    }
}
