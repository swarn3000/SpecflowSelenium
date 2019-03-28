using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace SeleniumProject
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver = null;
        [Given(@"I am on the user form page")]
        public void GivenIAmOnTheUserFormPage()
        {

           driver = new ChromeDriver();
           driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
          // ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill firstname ""(.*)"" and fill the middlename ""(.*)"" in the fields")]
        public void WhenIFillFirstnameAndFillTheMiddlenameInTheFields(string Fname, string Mname)
        {
            
            LoginPage s = new LoginPage(driver);
            s.EnterUserNameAndPassword(Fname,Mname);
            //s.ClickLogin();
        }
        
        [Then(@"I close browser")]
        public void ThenICloseBrowser()
        {
            //driver.Close();
            driver.Quit();
            //ScenarioContext.Current.Pending();
        }
    }
}
