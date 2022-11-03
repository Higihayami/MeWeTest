// Generated by Selenium IDE
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

namespace MeWeTest{
    [TestFixture]
    public class AutoTest_One : TestBase
    {

        [Test]
        public void login()
        {
            AccountData user = new AccountData("fatikoff2002@mail.ru", "DaniilFatykov");
            app.Navigation.OpenLoginPage();
            app.Auth.Login(user);
        }

        [Test]
        public void post()
        {
            AccountData user = new AccountData("fatikoff2002@mail.ru", "DaniilFatykov");
            GroupData post = new GroupData("Hello world") { Header = "sds", Footer = "dsfsd" }; ;
            app.Navigation.OpenLoginPage();
            app.Auth.Login(user);
            Thread.Sleep(20000);
            app.Navigation.OpenNavigationMenu();
            Thread.Sleep(5000);
            app.Navigation.OpenProfilePage();
            Thread.Sleep(5000);
            app.Group.NewPost(post);
        }
    }
}

