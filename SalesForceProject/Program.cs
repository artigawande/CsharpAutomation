using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Maveric.Salesforce
{
    public class SalesforceWebsite
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            driver.FindElement(By.Name("UserTitle")).SendKeys("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Corparate");
            driver.FindElement(By.Name("CompanyEmployees")).SendKeys("101-500 employees");
            driver.FindElement(By.Name("CompanyCountry")).SendKeys("United Kingdom");
            driver.FindElement(By.Name("UserPhone")).SendKeys("");


            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
            
        }
    }
}
