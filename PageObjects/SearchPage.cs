using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace UnitTestProject1
{
    public class SearchPage
    {
        // Search page steps
        IWebDriver driver;
        By STopS1 = By.XPath("/html/body/div/div[2]/div/div[3]/div[1]/div[1]/div/ul/li[1]/a/img");
        By SAtC   = By.Id("add_to_cart");
        By SCS    = By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span");
        By SFR = By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[5]");
        By SChout = By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a");

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Cl_1st_Item() //click 1st item from the Top seller
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(STopS1));
            driver.FindElement(STopS1).Click();
        }

        public void  Cl_add_to_Cart()
        {
            driver.FindElement(SAtC).Click();
        }

        public void Cl_Cont_Shop()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(SCS));
            driver.FindElement(SCS).Click();
        }

        public void Cl_2nd_Item()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(SFR));
            driver.FindElement(SFR).Click();
        }

        public void Cl_Checkout()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(SChout));
            driver.FindElement(SChout).Click();
        }
    }

}
