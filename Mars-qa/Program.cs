using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    /*private static void Main(string[] args)
    {
        // open chrome browser
        IWebDriver driver = new ChromeDriver();

        // lanuch The Mars-QA application
        driver.Navigate().GoToUrl("http://localhost:5000/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(1000);

        // Click the signin button
        IWebElement signButton = driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
        signButton.Click();

        // identify Emailtextbox enter valid Email id
        IWebElement emailTextbox = driver.FindElement(By.Name("email"));
        emailTextbox.SendKeys("spriyak86@gmail.com");

        // Identify password textbox enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
        passwordTextbox.SendKeys("KkMnithi@55");
        Thread.Sleep(1000);
        // check user has checked successfully
        IWebElement remembermeCheckbox = driver.FindElement(By.Name("rememberDetails"));
        remembermeCheckbox.Click();
        // click longin button
        IWebElement loginButton = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        loginButton.Click();
        Thread.Sleep(2000);

       IWebElement HiSathiyapriya = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        if (HiSathiyapriya.Text == "Hi Sathiyapriya")
        {
            Console.WriteLine("user has logged in succesfully");
        }
        else
        {
            Console.WriteLine("user has not logged");
        }

        //go to the language 
          IWebElement languageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        languageTab.Click();

        IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        addnewButton.Click();
        
        // Generate a random language value
        Random random = new Random();
        string[] languages = { "English", "Hindi", "French", "German" };
        int index = random.Next(languages.Length);
        string randomLanguage = languages[index];

        // Find the input field or element where you want to send the random language value
        IWebElement languageInput = driver.FindElement(By.Name("name"));

        // Send the random language value to the input field
        languageInput.SendKeys(randomLanguage);
        Console.WriteLine("Language has been added Successfully");

        Random levelrandom = new Random();
        string[] chooselanguageslevel = { "Basic", "Conversational", "Fluent", "Native/Bilingual" };
        int level = random.Next(chooselanguageslevel.Length);
        string randomLevel = chooselanguageslevel[level];
        Thread.Sleep(2000);


        IWebElement selectlevelInput = driver.FindElement(By.Name("level"));
        selectlevelInput.Click();
        Thread.Sleep(2000);
        selectlevelInput.SendKeys(randomLevel);
        Console.WriteLine("Language Level has been selected successfully");


        IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
        addButton.Click();

        Console.WriteLine("Language has been successfully added to the profile page");

        // Edit the lauange
        IWebElement editexistingLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        editexistingLanguage.Click();

        IWebElement editlanguageInput = driver.FindElement(By.Name("name"));
        editlanguageInput.Clear();
        editlanguageInput.SendKeys("Tamil");

        Random editlevelrandom = new Random();
        string[] editchooselanguageslevel = { "Basic", "Conversational", "Fluent", "Native/Bilingual" };
        int editlevel = random.Next(editchooselanguageslevel.Length);
        string editrandomLevel = chooselanguageslevel[level];
        Thread.Sleep(2000);


        IWebElement editselectlevelInput = driver.FindElement(By.Name("level"));
        selectlevelInput.Click();
        Thread.Sleep(2000);
        selectlevelInput.SendKeys(randomLevel);
        Console.WriteLine("Language Level has been selected successfully");


        IWebElement editupdateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
        editupdateButton.Click();


        Console.WriteLine("Edited Existing Language Successfully");



    }*/
}

