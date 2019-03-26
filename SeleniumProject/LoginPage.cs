using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using SeleniumExtras.PageObjects;

namespace SeleniumProject
{
    public class LoginPage
    {

        //Classical way of initializing Pages via POM concept - Until Selenium 3.10.0


        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement txtPassword { get; set; }

        //[FindsBy(How = How.Id, Using = "Save")]
        //public IWebElement btnLogin { get; set; }

        //RemoteWebDriver _driver;

        //public LoginPage(RemoteWebDriver driver) => _driver = driver;

        //IWebElement TxtUserName => _driver.FindElementByName("FirstName");
        //IWebElement TxtPassword => _driver.FindElementByName("MiddleName");
        //IWebElement BtnLogin => _driver.FindElementByName("Save");

        public void EnterUserNameAndPassword(string uName, string pword)
        {
            txtUserName.SendKeys(uName);
            txtPassword.SendKeys(pword);
        }

        public void ClickLogin()
        {
            //btnLogin.Click();
        }


    }
}
