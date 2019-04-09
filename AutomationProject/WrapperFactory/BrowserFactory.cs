using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject.WrapperFactory
{
     class BrowserFactory
    {
        private static readonly Dictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;
        private static ProjectURL m; 
        

        public BrowserFactory() {

            
        }
        

        public static IWebDriver Driver
        {
            get {
               // if (driver == null)
                //   throw new NullReferenceException("Mate this doesn't exist");
              return driver;

            }

            private set {
                driver = value; 
            }          
        }

        public static void InitBrowser(string browserName) {

            switch (browserName) {

                case "Chrome":
                    if (Driver == null) {
                        driver = new ChromeDriver(Environment.CurrentDirectory);
                        Drivers.Add(browserName, driver);
                    }
                    break;


            }

        }


        public static void loadApplication() {
            m = new ProjectURL();
            Driver.Url = m.URL;

        }

        public static void CloseAllBrowsers() {

            foreach (var drivers in Drivers.Keys) {
                Drivers[drivers].Close();
                Drivers[drivers].Quit();
            }
        }


    }
}
