using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvance
{
    
    public class ActionDemo
    {
        [Test]
        public void NassomTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.LinkText("Membership"))).Build().Perform();

            driver.FindElement(By.XPath("//a[text()='Members Listing']")).Click();
        }


        [Test]
        public void NassomTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.LinkText("Membership"))).
                MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Build().Perform();


            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
        }

        [Test]

        public void KeyBoardDemoTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://google.com";
            Actions actions = new Actions(driver);

            actions.KeyDown(Keys.Shift).SendKeys("Hello World").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1)).
                SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(1)).
                SendKeys(Keys.Enter).Build().Perform();

               
        }

    }
}
