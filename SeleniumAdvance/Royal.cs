using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAdvance
{
    public class Royal
    {
        [Test]
        public void RoyalCaribbean()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.royalcaribbean.com/";

            driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();

            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();

            driver.FindElement(By.XPath("//a[@class='login__create-account login__create-account--royal']")).Click();
            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("Dennis ");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("Rich");

            SelectElement element = new SelectElement(driver.FindElement(By.XPath("//div[@class='mat-select-arrow ng-tns-c51-12']")));
            element.SelectByText("April");

            SelectElement element1 = new SelectElement(driver.FindElement(By.XPath("//div[@class='mat-select-arrow ng-tns-c51-14']")));
            element1.SelectByText("4");

            SelectElement element2 = new SelectElement(driver.FindElement(By.XPath("//input[@data-placeholder='Year']")));
            element2.SelectByText("1990");

            SelectElement element3 = new SelectElement (driver.FindElement(By.LinkText("Country/Region of residence")));
            element3.SelectByText("INDIA");

            driver.FindElement(By.XPath("//input[@data-placeholder='Email address']")).SendKeys("drich@123.com");

            driver.FindElement(By.XPath("//input[@data-placeholder='Create new password']")).SendKeys("dennis@123");

            SelectElement element4 = new SelectElement (driver.FindElement(By.XPath("//div[@class='mat-select-arrow ng-tns-c51-19']")));
            element4.SelectByText("What was your first car's make or model?");

            driver.FindElement(By.XPath("//input[@data-placeholder='Answer']")).SendKeys("swift");


        }



        }
    }
