using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://github.com/login";

            string title = driver.Title;
            Console.WriteLine(driver.Title);

            Console.WriteLine(driver.Url); //get

            //get the page source and print it

        }
    }
}
