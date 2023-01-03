using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class OpenEmr
    {
        [Test]
        public static void OpenEMR1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = " http://demo.openemr.io/b/openemr/";

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control']")));
            select.SelectByText("English (Indian)");

            driver.FindElement(By.Id("login-button")).Click();
            driver.FindElement(By.XPath("(//div[@aria-expanded='false'])[1]")).Click();
            driver.FindElement(By.XPath("(//div[@class='menuLabel px-1'])[6]")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));

            driver.FindElement(By.Id("form_fname")).SendKeys("Neena");
            driver.FindElement(By.Id("form_lname")).SendKeys("Wick");
            driver.FindElement(By.Id("form_DOB")).SendKeys("02-01-2023");
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("form_sex")));
            select1.SelectByText("Female");

            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("form_gender_identity")));
            select2.SelectByText("Identifies as Female");

            driver.FindElement(By.Id("create")).Click();
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='modalframe']")));
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(50000);

            string alerttext = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alerttext);

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(30000);
            driver.FindElement(By.XPath("//div[@data-dismiss='modal']")).Click();
            
            string patientname = driver.FindElement(By.XPath("//span[@data-bind='text: pname()']")).Text;
            Console.WriteLine(patientname);




           



        }
    }
}

