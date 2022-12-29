using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting/";

            driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();

            driver.FindElement(By.XPath("//a[text()='Try Free']")).Click();
        }
    }
}
