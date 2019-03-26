using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace SeleniumProject
{
    //class Program
    //{
    //    //IWebDriver driver = new ChromeDriver();
    //    //private RemoteWebDriver _driver;

    //    //public Program(RemoteWebDriver driver)
    //    //{
    //    //    _driver = driver;
    //    //}
    //   // [BeforeTestRun]
    //    //[SetUp]
    //    public void Initiate()
    //    {
    //        BaseUtil.driver = new ChromeDriver();
    //        BaseUtil.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
    //    }
    //    //[Test]
    //   // public void Execute()
    //    //{

    //        //Initialize the page  by calling its reference
    //       // LoginPage page1 = new LoginPage();
    //         //   page1.EnterName("ss", "dd");







    //        ////Title
    //        //SeleniumSetMethod.EnterText("Initial", "Mr.",PropertyType.Id);

    //        //Console.WriteLine("The value of my Initial is: " + SeleniumGetMethod.GetText( "Initial", PropertyType.Id));

    //        ////IWebElement element = driver.FindElement(By.Id("Initial"));
    //        ////element.SendKeys("Mr.");
    //    //}
    //    [AfterTestRun]
    //    //[TearDown]
    //    public void TearDown()
    //    {
    //        BaseUtil.driver.Close();

    //    }
   // }
}
