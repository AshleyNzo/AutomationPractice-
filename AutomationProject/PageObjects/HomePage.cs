using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject.PageObjects
{
    public class HomePage
    {
        
     


        [FindsBy(How = How.ClassName, Using ="login" )]
        private IWebElement Signin { get; set; }

        

        public void ClickOnSignInButton() {

            Signin.Click();
        }

    



    }
}
