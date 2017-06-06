using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.ChangePaswordPages
{
    public partial class ChangePasswordPage
    {
        public IWebElement CurrentPasswordField
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"OldPassword\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"OldPassword\"]"));
            }
        }
        public IWebElement NewPasswordField
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"NewPassword\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"NewPassword\"]"));
            }
        }
        public IWebElement ConfirmNewPasswordField
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"ConfirmPassword\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"ConfirmPassword\"]"));
            }
        }
        public IWebElement ChangePasswordButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input"));
            }
        }
        public IWebElement CurrentPasswordError
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));
            }
        }
        public IWebElement NewPasswordError
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]"));
            }
        }
        public IWebElement HelloUserButtonMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));
            }
        }
        public IWebElement ChangeYourPasswordButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/dl/dd/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a"));
            }
        }
        public IWebElement ChangePasswordError
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }
        public IWebElement LoginButtonMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("loginLink")));
                return this.Driver.FindElement(By.Id("loginLink"));
            }
        }
    }
}