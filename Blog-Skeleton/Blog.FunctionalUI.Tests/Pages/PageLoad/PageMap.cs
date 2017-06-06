using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.PageLoad
{
    public partial class Page
    {
        public IWebElement RegisterButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("registerLink")));
                return this.Driver.FindElement(By.Id("registerLink"));
            }
        }
        public IWebElement PageTitle
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/h2")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            }
        }
        public IWebElement Logo
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[1]/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a"));
            }
        }
        public IWebElement LoginPageButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("loginLink")));
                return this.Driver.FindElement(By.Id("loginLink"));
            }
        }

    }
}

