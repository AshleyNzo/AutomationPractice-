using AutomationProject.WrapperFactory;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }
        

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }
    }
}
