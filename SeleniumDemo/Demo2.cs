using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class Demo2
    {
       public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.medibuddy.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

            driver.FindElement(By.XPath("//a[@ng-click=\"userSignin()\"]")).Click();

            driver.FindElement(By.XPath("//div[text()='I have an Insurance/Corporate Account']")).Click();

            driver.FindElement(By.XPath("//div[text()='Login using Username & Password']")).Click();

            driver.FindElement(By.Name("userName")).SendKeys("John");

            driver.FindElement(By.XPath("//button[text()='Proceed']")).Click();

            driver.FindElement(By.Name("password")).SendKeys("john123 ");

            driver.FindElement(By.XPath("//span[text()='Show password']")).Click();

            driver.FindElement(By.XPath("//button[text()='Log in']")).Click();


            string Errormassage = driver.FindElement(By.XPath("//*[contains(text(), 'incorrect')")).Text;
            Console.WriteLine(Errormassage);




        }
    }
}
