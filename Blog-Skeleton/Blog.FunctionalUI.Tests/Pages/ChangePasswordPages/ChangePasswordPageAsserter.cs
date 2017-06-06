using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.ChangePaswordPages
{
    public static class ChangePasswordPageAsserter
    {
        public static void AssertCurrentPasswordError(this ChangePasswordPage page, string text)
        {

            Assert.AreEqual(text, page.CurrentPasswordError.Text);

        }
        public static void AssertNewPasswordError(this ChangePasswordPage page, string text)
        {

            Assert.AreEqual(text, page.NewPasswordError.Text);

        }
        public static void AssertChangePasswordError(this ChangePasswordPage page, string text)
        {

            Assert.AreEqual(text, page.ChangePasswordError.Text);

        }
        public static void AssertChangePasswordErrors(this ChangePasswordPage page, string[] text)
        {
            List<string> actual = new List<string>() { page.CurrentPasswordError.Text, page.NewPasswordError.Text };
            CollectionAssert.AreEqual(text, actual);

        }
    }
}
