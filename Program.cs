using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ITF2
{
    class Program
    {
       public static void Main(string[] args)
        {
            //instantiate chrome driver 
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.co.uk/sport/all-sports");


        }
    }
}
