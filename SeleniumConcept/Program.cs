using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            //IWebDriver driver1= new ChromeDriver();

            driver.Url = "https://github.com/login";  //set

            string title = driver.Title;
            Console.WriteLine(driver.Title);

            Console.WriteLine(driver.Url); //get

            //get the page source and print it

            Console.WriteLine(driver.PageSource);

        }
    }
}
