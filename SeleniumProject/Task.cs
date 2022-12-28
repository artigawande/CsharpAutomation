using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Task
    {
        public static void Main(string[] agrs)
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);

            driver.FindElement(By.Name("customer.firstName")).SendKeys("Arti");
            driver.FindElement(By.Name("customer.lastName")).SendKeys("Gawande");
            driver.FindElement(By.Name("customer.address.street")).SendKeys("DP road Akola");
            driver.FindElement(By.Name("customer.address.city")).SendKeys("Akola");
            driver.FindElement(By.Name("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Name("customer.address.zipCode")).SendKeys("123456");
            driver.FindElement(By.Name("customer.phoneNumber")).SendKeys("8978564534");
            driver.FindElement(By.Name("customer.ssn")).SendKeys("123");
            driver.FindElement(By.Name("customer.username")).SendKeys("Arti@123");
            driver.FindElement(By.Name("customer.password")).SendKeys("ArtiG@123434");
            driver.FindElement(By.TagName("repeatedpassword")).SendKeys("ArtiG@123434");
            driver.FindElement(By.TagName("submit")).Click();

           
        }
    }
}
