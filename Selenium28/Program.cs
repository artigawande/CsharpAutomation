

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Maveric.Sychronization
{
    public class Task
    {
        public static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Url = "https://www.medibuddy.in/";

            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
                

            
        }
    }
}
