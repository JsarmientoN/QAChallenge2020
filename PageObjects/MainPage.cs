using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    public class MainPage
    {
        // Main page steps
        IWebDriver driver;
        By MSearchBar = By.Id("search_query_top");
        By MCont      = By.Id("contact-link");

        public MainPage(IWebDriver driver)  
        {
            this.driver = driver;
        }

        public void MainSearch()
        {
            driver.FindElement(MSearchBar).SendKeys("eve");
            driver.FindElement(MSearchBar).SendKeys(Keys.Enter);
        }

        public void Click_Contact()
        {
            driver.FindElement(MCont).Click();
        }
    }
}
