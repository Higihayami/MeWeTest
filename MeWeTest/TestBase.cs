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
    public class TestBase
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        public IJavaScriptExecutor js;
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

        public void Login(AccountData user)
        {
            driver.FindElement(By.Id("email")).SendKeys(user.Username);
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys(user.Password);
            driver.FindElement(By.CssSelector(".form")).Click();
        }

        public void MangeWindow()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1097, 662);
        }

        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl("https://mewe.com/login");
        }

        public void NewPost(GroupData post)
        {
            driver.FindElement(By.CssSelector(".postbox-placeholder_text")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".ql-editor"));
                js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = "+ post.Name +"}", element);
            }
            driver.FindElement(By.CssSelector(".group-bg")).Click();
        }

        public void OpenProfilePage()
        {
            driver.FindElement(By.CssSelector(".h-avatar--32 > .h-avatar_img")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("My Profile")).Click();
        }
    }
}
