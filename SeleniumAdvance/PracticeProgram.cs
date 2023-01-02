using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumAdvance
{
    public class PracticeProgram
    {
        [Test]
        public void RedBus()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.redbus.in/";

            driver.FindElement(By.XPath("//div[@id='sign-in-icon-down']")).Click();
            driver.FindElement(By.XPath("//li[@id='signInLink']")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("7898");

           

            String print = driver.FindElement(By.XPath("//span[@class='error-message-fixed error-message-full top-fix']")).Text;
            Console.WriteLine(print);

        }

        
        
    }
}
