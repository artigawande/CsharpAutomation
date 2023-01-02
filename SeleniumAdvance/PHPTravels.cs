using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System.Reflection.Metadata;

namespace SeleniumAdvance
{
    public class PHPTravels
    {
        [Test]
        public void PHPTravels1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.phptravels.net/home";

            driver.FindElement(By.XPath("//a[@title='flights']")).Click();

            driver.FindElement(By.Name("from")).SendKeys("Los Angeles");
            
            driver.FindElement(By.Name("to")).SendKeys("Dallas");

            //SelectElement demo = new SelectElement( driver.FindElement(By.Id("departure")));
            //demo.SelectByText("30-05-2022");

            driver.ExecuteJavaScript("document.querySelector('#departure').value = '30-05-2022'");

            driver.FindElement(By.XPath("//a[@class='dropdown-toggle dropdown-btn travellers waves-effect']")).Click();

            SelectElement select = new SelectElement (driver.FindElement(By.Name("adults")));
            select.SelectByText("2");
            //driver.FindElement(By.ClassName("(//div[@class='qtyInc'])[1]")).Click();





        }
    }
}
