using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class Demo3
    {
        public static void Main(string[] args)
        {
            ChromeDriver driver= new ChromeDriver();

            driver.Url = "https://nasscom.in/";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
            driver.FindElement(By.XPath("//li[text()='register']")).Click();

            driver.FindElement(By.Name("field_fname_reg[0][value]")).SendKeys("Krishna");
            driver.FindElement(By.Name("field_lname[0][value]")).SendKeys("Patil");

            driver.FindElement(By.Id("edit-mail")).SendKeys("Krishna@123.com");
            driver.FindElement(By.Id("edit-field-company-name-registration-0-value")).SendKeys("Maveric");

            SelectElement business = new SelectElement (driver.FindElement(By.Id("edit-field-business-focus-reg")));
            business.SelectByText("IT Consulting");

            driver.FindElement(By.XPath("//div[@class='recaptcha-checkbox-border']")).Click();

            driver.FindElement(By.Id("edit-submit--2")).Click();
        }
    }
}
