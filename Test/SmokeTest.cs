using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest2
    {
        public IWebDriver driver;
        
        [SetUp]
        public void init()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void ContactSmoke()
        {
            MainPage MP = new MainPage(driver);
            ContactPage CoP = new ContactPage(driver);
            MP.Click_Contact();
            CoP.Cl_Sel_Desti();
            CoP.Cl_SenK_email();
            CoP.Cl_SenK_message();
            CoP.Cl_SenK_Order();
            CoP.Cl_Subm();
            CoP.Cl_HomLogo();
        }

        [Test]
        public void CartSmoke()
        {

            MainPage MP = new MainPage(driver);
            ContactPage CoP = new ContactPage(driver);
            SearchPage SeP = new SearchPage(driver);
            MP.MainSearch();
            SeP.Cl_1st_Item();
            SeP.Cl_add_to_Cart();
            SeP.Cl_Cont_Shop();
            CoP.Cl_HomLogo();
            MP.MainSearch();
            SeP.Cl_2nd_Item();
            SeP.Cl_add_to_Cart();
            SeP.Cl_Checkout();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
