using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.ArticlePages
{
    public static class ArticlePageAsserter
    {
        public static void AssertArticleRequiredFields(this ArticlePage page, string[] text)
        {
            List<string> actual = new List<string>() { page.ArticleErrorTitleRequired.Text, page.ArticleErrorContentRequired.Text };
            CollectionAssert.AreEqual(text, actual);
        }
        public static void AssertArticleError(this ArticlePage page, string text)
        {
            Assert.AreEqual(text, page.ArticleError.Text);

        }
        public static void AssertArticleContent(this ArticlePage page, string text)
        {
            Assert.AreEqual(text, page.Content.Text);

        }
    }
}
