using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage : DriverHelper
    {


        IWebElement txtUsername => Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Id("Password"));

        IWebElement logInButton => Driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input"));

        public void ClickLogin() => logInButton.Click();

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
        
        }


    }
}
