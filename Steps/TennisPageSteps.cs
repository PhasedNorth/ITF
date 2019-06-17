using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace ITF2.Steps
{
    [Binding]
    public sealed class TennisPageSteps
    {
        private IWebDriver driver;


        [Given]
        public void GivenThatIHaveNavigatedOnTheSportsAZPage()
        {
            driver = new ChromeDriver { Url = "https://www.bbc.co.uk/sport/all-sports" };

            var element = driver.FindElement(By.LinkText("Tennis"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Click();


        }

        [When]
        public void WhenIScrollAndClickOnTennis()
        {

            //driver.FindElement(By.XPath("//*[@id=\"page\"]/div[2]/div[2] > gel-wrap > layout > layout__ghost-column > component > div[16]/nav/ul/li[3]/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"page\"]/div[2]/div[2]/div/div/div/div/div[16]/nav/ul/li[3]/a")).Click();
        }



        [When]
        public void WhenISeeAndClickOnZverevTsitsipasSufferShockDefeats()
        {
            var element = driver.FindElement(By.PartialLinkText("Zverev"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);

            driver.FindElement(By.XPath("//*[@id=\"top-stories\"]/div[1]/div[1]/div/div[7]/article/div/div[1]/h3/a/span")).Click();
        }

        [Then]
        public void ThenISeeTheArticleMainImage()
        {
            Assert.That(driver.FindElement(By.XPath("//*[@id=\"story-body\"]/figure/div/div")).Displayed);
            driver.Close();
        }
    }
}