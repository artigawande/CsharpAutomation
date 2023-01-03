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
using OpenQA.Selenium.Interactions;

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

            Actions actions = new Actions(driver);

            //actions.MoveToElement(driver.FindElement(By.Name("from"))).SendKeys("Los Angeles").
               // MoveToElement(driver.FindElement(By.LinkText("Los Angeles, United States"))).Build().Perform();

            driver.FindElement(By.Name("from")).SendKeys("Los Angeles");
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).
                Pause(TimeSpan.FromSeconds(1)).SendKeys(Keys.Enter).Build().Perform();

            Thread.Sleep(3000);


             driver.FindElement(By.Name("to")).SendKeys("Dallas");
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();

            //SelectElement demo = new SelectElement( driver.FindElement(By.Id("departure")));
            //demo.SelectByText("30-05-2022");
            Thread.Sleep(3000);

            driver.ExecuteJavaScript("document.querySelector('#departure').value='30-01-2023'");

            //driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//i[contains(@class,'la la-plus ')]")).Click();

            driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();

            

            driver.FindElement(By.Id("flights-search")).Click();

            string print = driver.FindElement(By.XPath("//div[@class='theme-search-results-item-preview']")).Text;
            Console.WriteLine(print);


            Thread .Sleep(1000);
            driver.Quit();



        }
    }
}
