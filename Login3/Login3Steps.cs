using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace Login3
{
    [Binding]
    public class Login3Steps
    {
        public IWebDriver driver = new ChromeDriver();
        [Given(@"Navigate user to LogIn Page")]
        public void GivenNavigateUserToLogInPage()
        {
            driver.Navigate().GoToUrl("https://profile.w3schools.com/");
            Thread.Sleep(5000);
            driver.Manage().Window.Maximize();
        }
        
        [When(@"User enter UserName(.*) and Password(.*)")]
        public void WhenUserEnterUserNameAndPassword(string email, string password)
        {
            driver.FindElement(By.Name("email")).SendKeys(email);
            Thread.Sleep(2000);
            driver.FindElement(By.Name("current-password")).SendKeys(password);
            Thread.Sleep(5000);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.ClassName("Button_fullwidth__0HLEu")).Click();
            Thread.Sleep(10000);
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            Console.WriteLine("Login Successful");
            Thread.Sleep(10000);
            Console.WriteLine("Closing the windows after test ran successful");
           
            driver.Quit();
        }  
    }
}
