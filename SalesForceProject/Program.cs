using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Maveric.Salesforce
{
    public class SalesforceWebsite
    {
       // private static object selectTitle;

        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            driver.FindElement(By.Name("UserTitle")).SendKeys("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");

            SelectElement selectEmployee = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployee.SelectByText("101-500 employees");

           // driver.FindElement(By.Name("CompanyCountry")).SendKeys("United Kingdom");
            driver.FindElement(By.Name("UserPhone")).SendKeys("");

            SelectElement selectcountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectcountry.SelectByText("Palau");


            driver.FindElement(By.XPath("//*[@id=\"signup_form_pawq\"]/div[5]/div/div/div[1]")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
            
        }
    }
}
