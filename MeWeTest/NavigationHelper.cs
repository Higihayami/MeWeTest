using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace MeWeTest
{
    public class NavigationHelper : HelperBase
    {

        private string baseURL;
        public NavigationHelper(ApplicationManager manager, string baseURL)
                    : base(manager)
        {
            this.baseURL = baseURL;
        }


        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl("https://mewe.com/login");
        }

        public void OpenProfilePage()
        {
            driver.FindElement(By.LinkText("My Profile")).Click();
        }

        public void OpenNavigationMenu()
        {
            driver.FindElement(By.CssSelector(".h-avatar--32 > .h-avatar_img")).Click();
        }

    }
}
