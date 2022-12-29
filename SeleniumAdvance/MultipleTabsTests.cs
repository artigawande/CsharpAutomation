using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    public class MultipleTabsTests
    {
        [Test]
        public void PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);

            driver.Url = " https://www.db4free.net/";

            driver.FindElement(By.XPath("//a[@target='_blank']")).Click();


        }
    }
}
