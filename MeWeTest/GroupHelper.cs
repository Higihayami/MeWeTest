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
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public void NewPost(GroupData post)
        {
            driver.FindElement(By.CssSelector(".postbox-placeholder_text")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".ql-editor"));
                js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = " + post.Name + "}", element);
            }
            driver.FindElement(By.CssSelector(".group-bg")).Click();
        }
    }
}
