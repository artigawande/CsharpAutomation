﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class Demo3
    {
        public static void Main(string[] args)
        {
            ChromeDriver driver= new ChromeDriver();

            driver.Url = "https://nasscom.in/";

            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
        }
    }
}