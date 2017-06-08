using Blog.FunctionalUI.Tests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.ArticlePages
{
    public partial class ArticlePage : BasePage

    {
        public ArticlePage(IWebDriver driver)
           : base(driver)
        {
            AccessExcelData.fileName = "ArticleData.xlsx";
        }

    
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Article/Create");
       
        }

        public void CreateArticle(CreateArticle article)
        {
            Type(ArticleTitle, article.Title);
            Type(ArticleContent, article.Content);

            ArticleCreateButton.Click();
        }

        public void EditArticle(string articleContent)
        {
            ArticleHello.Click();
            ArticleEditButton.Click();
            ArticleContent.Click();
            ArticleContent.Clear();
            Type(ArticleContent, articleContent);

            EditButtonSubmit.Click();
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
