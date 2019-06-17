using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ITF2.Pages
{
    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public BasePage(IWebDriver driver)
        { }

        //public IWebDriver Driver { get; internal set; }
        //public string GetTitle => Driver.Title;
        //public string GetUrl => Driver.Url;
        //public string GetPageSource => Driver.PageSource;



        // public void AccessMainEnterPoint()
        public void NavigateMainEnterPoint()

        {

            // load selenium webdriver instantiate Chrome Driver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.co.uk/sport/all-sports");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }
    }
}
