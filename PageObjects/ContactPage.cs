using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    public class ContactPage
    {
        // Contact us page steps
        IWebDriver driver;
        By CDestinary = By.Id("id_contact");
        By CEmail     = By.Id("email");
        By CMessage   = By.Id("message");
        By CSubmitm   = By.Id("submitMessage");
        By COrderN    = By.Id("id_order");
        By CHeadLogo  = By.ClassName("home");


        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Cl_Sel_Desti()
        {
            SelectElement dprDestinary = new SelectElement(driver.FindElement(CDestinary));
            dprDestinary.SelectByIndex(1);
        }

        public void Cl_SenK_email()
        {
            driver.FindElement(CEmail).SendKeys("emailyahoo@gmail.com");
        }

        public void Cl_SenK_message()
        {
            driver.FindElement(CMessage).SendKeys("test message test");
        }

        public void Cl_SenK_Order()
        {
            driver.FindElement(COrderN).SendKeys("6548");
        }


        public void Cl_Subm()
        {
            driver.FindElement(CSubmitm).Click();
        }

        public void Cl_HomLogo()
        {
            driver.FindElement(CHeadLogo).Click();
        }
    }
}
