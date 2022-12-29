using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class Demo1
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting/";

           driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.Id("truste-consent-button")).Click();

            //Thread.Sleep(1000);

            Actions actions = new Actions(driver);

            try
            {
                
                  actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch 
            {
            }

            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Try Free")).Click();

            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("Wick");
            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");
            driver.FindElement(By.Id("contact-number")).SendKeys("8978675645");
            

           SelectElement selectSize = new SelectElement (driver.FindElement(By.Name("CompanySize")));
            selectSize.SelectByText("10-99");

            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Term of Service"))).Perform();
            }
            catch
            {

            }

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();

            string errormassage = driver.FindElement(By.XPath("//span[text()='Password Requirements:']")).Text;
            Console.WriteLine(errormassage);

        }
    }
}
