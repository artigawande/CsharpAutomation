using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Data;

namespace Maveric.SubscriptionTest
{
    public class SubscriptionTest
    {
        [Test]
        public void AutomationWorld()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.automationworld.com/";

            driver.FindElement(By.XPath("//div[@class='close-olytics-image-bottom-midpurple']")).Click();

            Actions actions = new Actions(driver);
            actions.ScrollToElement(driver.FindElement(By.XPath("//a[text()='Subscribe']"))).Perform();

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[text()='Subscribe']")).Click();

            ReadOnlyCollection<String> windows = driver.WindowHandles;

            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);

            //switch to second tab.
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.XPath("//input[@id='id24_344']")).Click();

            driver.FindElement(By.XPath("//input[@name='demo59703']")).SendKeys("Krishna");

            driver.FindElement(By.XPath("//input[@name='demo59704']")).SendKeys("Deoke");

            driver.FindElement(By.XPath("//input[@name='demo59705']")).SendKeys("IT Manager");
            driver.FindElement(By.XPath("//input[@name='demo59708']")).SendKeys("Maveric-Systems");

            driver.FindElement(By.XPath("//input[@name='demo59706']")).SendKeys("krishna@123.com");

            driver.FindElement(By.XPath("//input[@name='demo59707']")).SendKeys("https://maveric-systems.com/");

            driver.FindElement(By.XPath("//input[@name='demo59709']")).SendKeys("7789675645");
            driver.FindElement(By.XPath("//input[@name='demo59713']")).SendKeys("Chennai");

            SelectElement element = new SelectElement(driver.FindElement(By.XPath("//select[@name='demo59710']")));
            element.SelectByText("INDIA");

            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(3000);

            string ErrorMessage = driver.FindElement(By.XPath("//div[text()='The email address you entered cannot be registered']")).Text;
            Console.WriteLine(ErrorMessage);


        }

        

        }
    }

