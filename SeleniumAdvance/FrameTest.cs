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
    public class FrameTest
    {
        [Test]
        public void Demo1Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //switch to the html using frame
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.XPath("//input[@name='fldLoginUserId']")).SendKeys("kevin123");

            driver.FindElement(By.XPath("//a[text()='CONTINUE']")).Click();

            //switch back to main html
            driver.SwitchTo().DefaultContent();

        }

        [Test]
        public void Demo2Alert()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            //handle the alert 
           string AlertText= driver.SwitchTo().Alert().Text;

            Console.WriteLine(AlertText);

            driver.SwitchTo().Alert().Accept();


        }
    }
}
