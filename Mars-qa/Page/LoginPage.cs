using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mars_qa.Page
{
    public class LoginPage : CommonDrive
    {
        public void loginSteps(IWebDriver driver)
        {
            //Launch Mars-QA Application
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            // Click the signin button
            IWebElement signButton = driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
            signButton.Click();

            // identify Emailtextbox enter valid Email id
            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            emailTextbox.SendKeys("spriyak86@gmail.com");
            
            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("KkMnithi@55");

            // check user has checked successfully
            IWebElement remembermeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            remembermeCheckbox.Click();

            // click longin button
            IWebElement loginButton = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            loginButton.Click();
            Thread.Sleep(3000);

            IWebElement HiSathiyapriya = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            if (HiSathiyapriya.Text == "Hi Sathiyapriya")
            {
                Assert.Pass(" Sathiyapriya has logged in succesfully");
            }
            else
            {
                Assert.Fail("Sathiyapriya has not been created successfully");
            }
        }
    }
}
