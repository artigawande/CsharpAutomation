using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class Demo4
    {
        public static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://www.oracle.com/in/database/";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.XPath("//span[text()='View Accounts']")).Click();

            driver.FindElement(By.XPath("//a[text()='Sign-In']")).Click();

            Console.WriteLine("The Title of the page :" + driver.Title);
            Console.WriteLine(" the current url of the page :" +driver.Title);

            driver.FindElement(By.XPath("//input[@name='ssousername']")).SendKeys("john");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("john123");
            driver.FindElement(By.XPath("//input[@class='sign-in-button']")).Click();

            Console.WriteLine("Invalid username and/or password :" + driver.Title);




            IWebElement text2 = driver.FindElement(By.XPath("(//div[@class='cb41error'])[2]"));
            Console.WriteLine(" Error message after invalid username and password:  " + text2.Text);




        }
    }
}
