using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Selenium.WebDriver.Extensions.Core;
using Selenium.WebDriver.Extensions.JQuery;
using Selenium.WebDriver.Extensions.QuerySelector;
using By = OpenQA.Selenium.By;


namespace ITF2
{

    [Binding]
    public class BbcHomepageSteps
    {
        private IWebDriver driver;

        [Given]
        public void GivenThatIAmOnTheSportsAZPage()
        {
            driver = new ChromeDriver { Url = "https://www.bbc.co.uk/sport/all-sports" };

            var element = driver.FindElement(By.LinkText("Tennis"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);

        }

        [When]
        public void WhenIScrollDownPageAndClickOnTennis()
        {

            driver.FindElement(By.XPath("//*[@id=\"page\"]/div[2]/div[2]/div/div/div/div/div[16]/nav/ul/li[3]/a")).Click();
        }


        [Then]
        public void ThenIAmNavigatedToTheTennisTab()
        {
            Assert.That(driver.FindElement(By.LinkText("Tennis")).Displayed);
            driver.Quit();
        }

    }
}