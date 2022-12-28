using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Task2
    {
        public static void Main(string[] agrs)
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Url = "https://demo.guru99.com/test/newtours/register.php";
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);

            driver.FindElement(By.Name("firstName")).SendKeys("Arti");
            driver.FindElement(By.Name("lastName")).SendKeys("Gawande");
            driver.FindElement(By.Name("address1")).SendKeys("DP road Akola");
            driver.FindElement(By.Name("city")).SendKeys("Akola");
            driver.FindElement(By.Name("state")).SendKeys("Maharashtra");
            driver.FindElement(By.Name("postalCode")).SendKeys("123456");
            driver.FindElement(By.Name("country")).SendKeys("");
            driver.FindElement(By.Name("phone")).SendKeys("8978564534");
          
            driver.FindElement(By.Id("email")).SendKeys("Arti@123");
            driver.FindElement(By.Name("password")).SendKeys("ArtiG@123434");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("ArtiG@123434");
            driver.FindElement(By.Name("submit")).Click();

            
        }
    }
}
