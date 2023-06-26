using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_qa.Page
{
    public class LanguagePage : CommonDriver
    {
        public void addLanguage(IWebDriver driver)
        {
            //create new record
            //select languagetab
           // IWebElement languagesTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
           // languagesTab.Click();
           // Thread.Sleep(2000);
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();

        }
        public void languageInput(IWebDriver driver)
        {
            //Generate random values in languagefield
            Random random = new Random();
            string[] languages = { "Tamil", "English", "Telugu", "Kannada" };
            //int index = random.Next(languages.Length);
            int index = random.Next(0, languages.Length);
            string randomLanguage = languages[index];

            //Enter the language input
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys(randomLanguage);
            Thread.Sleep(2000);
        }
        public void levelOption(IWebDriver driver)
        {

            //Select the level option
            //Generate random values in languagefield
            Random random = new Random();
            string[] levelOption = { "Basic", "Cnversational", "Fluent", "Native/Billingual" };
            //int index = random.Next(languages.Length);
            int index = random.Next(levelOption.Length);
            string randomLevel = levelOption[index];
            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.SendKeys(randomLevel);
            

             /*IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.Click();
           IWebElement nativeBillingualOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            nativeBillingualOption.Click();*/
        }
        public void createLanguage(IWebDriver driver)
        {
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
        }
        public string  GetVerifyLanguageCreation(IWebDriver driver)
        {
            //check if record added
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
           /* if (newLanguage.Text == "Tamil")
            {
                Assert.Pass("Language have been Successfully Created");
            }
            else
            {
                Assert.Fail("Language have not been Successfully Created");
            }*/
        }
        public void updateLanguage(IWebDriver driver)
        {
            //Click the edit Icon
            IWebElement editLanguage = driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            editLanguage.Click();

            //update the langu
        }

    }
}
        


    

