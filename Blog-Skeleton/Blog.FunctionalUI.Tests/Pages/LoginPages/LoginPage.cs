﻿using Blog.FunctionalUI.Tests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.LoginPages
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            AccessExcelData.fileName = "LogInData.xlsx";
        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Login");
           
        }

        public void FillLoginForm(LogInUser loginUser)
        {
            Type(EmailField, loginUser.Email);
            Type(PasswordField, loginUser.Password);

            LogInSubmit.Click();
        }

        private void Type(IWebElement element, string text)
        {

            element.Click();

            if (!text.Equals("Field-Empty"))
            {
                element.SendKeys(text);

            }
        }



    }
}
