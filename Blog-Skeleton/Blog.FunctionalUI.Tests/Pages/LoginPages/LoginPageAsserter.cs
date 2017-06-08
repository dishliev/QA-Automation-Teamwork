using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.LoginPages
{
    public static class LoginPageAsserter
    {
        public static void AssertLoginFormEmailError(this LoginPage page, string text)
        {

            Assert.AreEqual(text, page.EmailError.Text);

        }
        public static void AssertLoginFormPasswordError(this LoginPage page, string text)
        {

            Assert.AreEqual(text, page.PasswordError.Text);

        }

        public static void AssertInvalidLoginFormEmailPasswordErrors(this LoginPage page, string[] text)
        {
            List<string> actual = new List<string>() { page.EmailError.Text, page.PasswordError.Text };
            CollectionAssert.AreEqual(text, actual);

        }
        public static void AssertInvalidLoginFormError(this LoginPage page, string text)
        {

            Assert.AreEqual(text, page.InvalidLoginError.Text);

        }
        public static void AssertValidLogin(this LoginPage page, string text)
        {

            Assert.AreEqual(text, page.LogOffButton.Text);

        }
    }
}
