using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvance
{
    public class UploadDemo
    {
        [Test]
        public void PdfToWordConvertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.foundit.in/rio/login";

            Actions actions = new Actions(driver);
            
            Thread.Sleep(1000);
            actions.ScrollToElement (driver.FindElement(By.LinkText("Upload Resume"))).
                SendKeys("file:///C:/Users/artig/Downloads/UploadResume.pdf");
        }
    }
}
