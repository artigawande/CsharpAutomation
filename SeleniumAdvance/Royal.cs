using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;



namespace SeleniumAdvance
{
    public class RoyalCaribbean
    {
        [Test]
        public static void Royal()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            driver.Url = "https://www.royalcaribbean.com/account/create";
            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("Dennies");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("Rich");

            driver.FindElement(By.XPath("//span[normalize-space()='Month']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();

            driver.FindElement(By.XPath("//span[normalize-space()='Day']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()=2]")).Click();
            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("2000");


            driver.FindElement(By.XPath("//span[normalize-space()='Country/Region of residence']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='United States of America' ]")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("dreich@123.com");

            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("DRich123");

            driver.FindElement(By.XPath("//span[normalize-space()='Select one security question']")).Click();
            Actions actions = new Actions(driver);
            

            
          
           

            actions.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()='Select one security question']"))).Build().Perform();
            driver.FindElement(By.XPath("//span[normalize-space()=\"What was your first car's make or model?\"]")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Answer']")).Click();
           actions.MoveToElement (driver.FindElement(By.XPath("//input[@data-placeholder='Answer']"))).SendKeys("sdfgghhjjk").Perform();

            driver.FindElement(By.XPath("//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin'])[2]")).Click();
            driver.FindElement(By.XPath("//button[text()=' Done ']")).Click();
            
            // driver.FindElement(By)




            // driver.FindElement(By.XPath("//span[normalize-space()=\" What was your first car's make or model? \"]")).Click();










        }



    }
}