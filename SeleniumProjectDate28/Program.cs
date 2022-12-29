using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Maveric.Selenium
{
    public class Task
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.medibuddy.in/";

            driver.FindElement(By.XPath("")).Click();
        }
    }
}
