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
    public class HelperBase
    {
        protected IWebDriver driver;
        protected bool acceptNextAlert = true;
        public IDictionary<string, object> vars { get; private set; }
        public IJavaScriptExecutor js;

        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        public void MangeWindow()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1097, 662);
        }
    }
}
