using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.RegistrationPages
{
    public partial class RegistrationPage
    {
        public IWebElement Email
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Email\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
            }
        }
        public IWebElement FullName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"FullName\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"FullName\"]"));
            }
        }
        public IWebElement Password
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Password\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            }
        }
        public IWebElement ConfirmPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"ConfirmPassword\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"ConfirmPassword\"]"));
            }
        }
        public IWebElement RegisterButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/input"));
            }
        }
        public IWebElement Registration
        {

            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("registerLink")));
                return this.Driver.FindElement(By.Id("registerLink"));
            }
        }
        public IWebElement ErrorMessageEmailRequired
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));
            }
        }
        public IWebElement ErrorMessageFullNameRequired
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]"));
            }
        }
        public IWebElement ErrorMessagePasswordRequired
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[3]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[3]"));
            }
        }

        public IWebElement RegistrationFormError
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.CssSelector(" body > div.container.body-content > div > div > form > div.text-danger.validation-summary-errors > ul > li")));
                return this.Driver.FindElement(By.CssSelector(" body > div.container.body-content > div > div > form > div.text-danger.validation-summary-errors > ul > li"));

            }
        }
        public IWebElement NavBarHelloUser
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));

            }
        }


    }

}

