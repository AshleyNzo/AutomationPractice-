using AutomationProject.PageObjects;
using AutomationProject.WrapperFactory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationProject.StepDefinitions
{
    [Binding]
    public class LoginTestSteps
    {
        //IWebDriver driver;
        

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.loadApplication();
            
        }
        
        [When(@"I click signin")]
        public void WhenIClickSignin()
        {
            Page.Home.ClickOnSignInButton();
        }
        
        [Then(@"I should be on the signin page")]
        public void ThenIShouldBeOnTheSigninPage()
        {
            //   Assert.IsNotNull(driver.FindElement(By.ClassName("cat-title")));
            BrowserFactory.CloseAllBrowsers(); 
        }
    }
}
