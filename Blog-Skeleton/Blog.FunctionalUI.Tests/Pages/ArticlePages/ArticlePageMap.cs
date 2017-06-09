using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.ArticlePages
{
    public partial class ArticlePage
    {
        public IWebElement ArticleTitle
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Title\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"Title\"]"));
            }
        }
        public IWebElement ArticleContent
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Content\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"Content\"]"));
            }
        }
        public IWebElement ArticleCancelButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/a"));
            }
        }
        public IWebElement ArticleCreateButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));
            }
        }
        public IWebElement ArticleErrorTitleRequired
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));
            }
        }
        public IWebElement ArticleError
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }

        public IWebElement ArticleErrorContentRequired
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]"));
            }
        }

        public IWebElement ArticleHello
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/div[4]/article/header/h2/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[4]/article/header/h2/a"));
            }
        }
        public IWebElement ArticleEditButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/article/footer/a[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));
            }
        }
        public IWebElement EditButtonSubmit
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));
            }
        }
        public IWebElement Content
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/div[4]/article/p")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[4]/article/p"));
            }
        }
    }
}
