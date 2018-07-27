using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace SampleSelenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            //driver.Url = ;   
            //added a comment
            driver.Navigate().GoToUrl("https://nriorigtest.navient.com/");
            driver.FindElementById("FirstName").SendKeys("Aravind");
        }
    }
}
