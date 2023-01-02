using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System.Reflection.Metadata;

namespace SeleniumAdvance
{
    public class MultipleTabsCitiTest
    {
        [Test]
        public void ApplyCreditCard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.XPath("//a[@class='fancybox-item fancybox-close']")).Click();
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            ReadOnlyCollection<String> windows = driver.WindowHandles;

            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);

            //switch to second tab.
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.XPath("//div[@onclick='ForgotUserID();']")).Click();

            
            Thread.Sleep(3000);
            
            //select credit card
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

           
            //enter credit card number
            driver.FindElement(By.Id("citiCard1")).SendKeys("4545");
            driver.FindElement(By.Id("citiCard2")).SendKeys("5656");
            driver.FindElement(By.Id("citiCard3")).SendKeys("8887");
            driver.FindElement(By.Id("citiCard4")).SendKeys("9998");
            driver.FindElement(By.Name("CCVNO")).SendKeys("9998");

            /*driver.FindElement(By.Id("bill-date-long")).Click();
            SelectElement month = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")));
            month.SelectByText("Apr");
            SelectElement year = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")));
            year.SelectByText("2022");
            driver.FindElement(By.LinkText("14")).Click();*/


            //using javascript we automate the calender.
            driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value = '14/04/2022'");

            //proceed 
            driver.FindElement(By.XPath("//input[@type='button']")).Click();
            Thread.Sleep(1000);

            //text print for accept term and conditions
            string textPrint = driver.FindElement(By.XPath("//li[contains(text(),'• Please accept Terms and Conditions ')]")).Text;
            Console.WriteLine(textPrint);

            //close window
            driver.Quit();

        }
    }
}
