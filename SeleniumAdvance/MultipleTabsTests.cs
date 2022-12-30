using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    public class MultipleTabsTests
    {
        [Test]
        public void DemoPhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);

            driver.Url = " https://www.db4free.net/";

            driver.FindElement(By.XPath("//a[@target='_blank']")).Click();

           ReadOnlyCollection<String> windows =driver.WindowHandles;

            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);

            //switch to second tab.
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            SelectElement selectSize = new SelectElement (driver.FindElement(By.Id("languageSelect")));
            selectSize.SelectByText("English");

            driver.FindElement(By.Id("input_username")).SendKeys("Krishna");

            driver.FindElement(By.Name("pma_password")).SendKeys("Deoke");

            driver.FindElement(By.Id("input_go")).Click();

            string errormassage = driver.FindElement(By.Id("loginform")).Text;
            Console.WriteLine(errormassage);

            //driver.Close();
        }
    }
}
