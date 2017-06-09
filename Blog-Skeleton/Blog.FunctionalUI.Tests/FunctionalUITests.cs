using Blog.FunctionalUI.Tests.Attributes;
using Blog.FunctionalUI.Tests.Models;
using Blog.FunctionalUI.Tests.Pages.ArticlePages;
using Blog.FunctionalUI.Tests.Pages.ChangePaswordPages;
using Blog.FunctionalUI.Tests.Pages.LoginPages;
using Blog.FunctionalUI.Tests.Pages.PageLoad;
using Blog.FunctionalUI.Tests.Pages.RegistrationPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        IWebDriver driver = BrowserHost.Instance.Application.Browser;

       
        //Registration method negative data
        public void RegistrationWithNegativeData(string testName, params string[] assert)

        {

            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetRegistrationTestData(testName);

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            var asserter = typeof(RegistrationPageAsserter).GetMethod(user.Asserter);

            int assertLenght = assert.Length;
            if (assertLenght == 1)
            {
                var assertString = String.Concat(assert);

                asserter.Invoke(null, new object[] { regPage, assertString });

            }
            else
            {
                var str = assert;
                asserter.Invoke(null, new object[] { regPage, str });
            }
        }

        // Login method
        public void LoginWithNegativeData(string testName, params string[] assert)
        {

            var loginPage = new LoginPage(driver);
            var loginUser = AccessExcelData.GetLoginTestData(testName);

            loginPage.NavigateTo();
            loginPage.FillLoginForm(loginUser);

            var asserter = typeof(LoginPageAsserter).GetMethod(loginUser.Asserter);

            int assertLenght = assert.Length;
            if (assertLenght == 1)
            {
                var assertString = String.Concat(assert);

                asserter.Invoke(null, new object[] { loginPage, assertString });

            }
            else
            {
                var str = assert;
                asserter.Invoke(null, new object[] { loginPage, str });
            }
        }

        //Article method
        public void CreateArticleNegativeTests(string testName, params string[] assert)
        {
            var articlePage = new ArticlePage(driver);
            var article = AccessExcelData.GetArticleTestData(testName);

            articlePage.NavigateTo();

            //  LOGIN
            var loginPage = new LoginPage(driver);
            var loginUser = AccessExcelData.GetLoginTestData("LoginWithValidData");

            loginPage.FillLoginForm(loginUser);
            articlePage.CreateArticle(article);

            var asserter = typeof(ArticlePageAsserter).GetMethod(article.Asserter);

            int assertLenght = assert.Length;
            if (assertLenght == 1)
            {
                var assertString = String.Concat(assert);

                asserter.Invoke(null, new object[] { articlePage, assertString });

            }
            else
            {
                var str = assert;
                asserter.Invoke(null, new object[] { articlePage, str });
            }
        }

        //Change Password method
        public void ChangePasswordWithNegativeData(string testName, params string[] assert)

        {

            var passPage = new ChangePasswordPage(driver);
            var password = AccessExcelData.GetPasswordTestData(testName);

            passPage.NavigateTo();

            //Login
            var loginPage = new LoginPage(driver);
            var loginUser = AccessExcelData.GetLoginTestData("LoginWithValidData");

            loginPage.FillLoginForm(loginUser);


            passPage.NavigateToChangePassword();
            passPage.FillChangePasswordForm(password);

            var asserter = typeof(ChangePasswordPageAsserter).GetMethod(password.Asserter);

            int assertLenght = assert.Length;
            if (assertLenght == 1)
            {
                var assertString = String.Concat(assert);

                asserter.Invoke(null, new object[] { passPage, assertString });

            }
            else
            {
                var str = assert;
                asserter.Invoke(null, new object[] { passPage, str });
            }
        }

        //Registration Tests

        //Registration valid data
        [Test]
        [LogResultToFileAttribute]
        public void RegistrationWithValidData()
        {
            // random fullName
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            //random password
            Random rnd = new Random(234234234);

            var fullName = new String(stringChars);
            var email = fullName + "@abv.bg";
            int randomPassword = rnd.Next();
            string password = Convert.ToString(randomPassword);
            var confirmPassword = password;

            var regPage = new RegistrationPage(driver);
            var user = new RegistrationUserValidData(email, fullName, password, confirmPassword);

            regPage.NavigateTo();
            regPage.FillRegistrationFormValidData(user);

            regPage.AssertNavBarHelloUser("Hello " + email + "!");

        }

        //Registration negative data
        [LogResultToFileAttribute]
        [Test, Property("Registration", 1)]
        public void RegistrationWithEmptyFields()
        {

            RegistrationWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Email field is required.", "The Full Name field is required.", "The Password field is required." );

        }

        [LogResultToFileAttribute]
        [Test, Property("Registration", 1)]
        public void RegistrationWithInvalidEmail()
        {

            RegistrationWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Email field is not a valid e-mail address.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Registration", 1)]
        public void RegistrationWithoutPassword()
        {

            RegistrationWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Password field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Registration", 1)]
        public void RegistrationWithoutConfirmPassword()
        {

            RegistrationWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The password and confirmation password do not match.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Registration", 1)]
        public void RegistrationWithoutEmail()
        {

            RegistrationWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Email field is required.");

        }
      
       
        //Login Tests
        [LogResultToFileAttribute]
        [Test, Property("Login", 1)]
        public void LoginWithEmptyFields()
        {

            LoginWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Email field is required.", "The Password field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Login", 1)]
        public void LoginWithoutEmail()
        {

            LoginWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Email field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Login", 1)]
        public void LoginWithoutPassword()
        {

            LoginWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Password field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Login", 1)]
        public void LoginWitInvalidEmail()
        {

            LoginWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Email field is not a valid e-mail address.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Login", 1)]
        public void LoginWitInvalidData()
        {
            LoginWithNegativeData(TestContext.CurrentContext.Test.MethodName, "Invalid login attempt.");
        }

        [LogResultToFileAttribute]
        [Test, Property("Login", 1)]
        public void LoginWithValidData()
        {
            var loginPage = new LoginPage(driver);
            var loginUser = AccessExcelData.GetLoginTestData(TestContext.CurrentContext.Test.MethodName);

            loginPage.NavigateTo();
            loginPage.FillLoginForm(loginUser);
          
            loginPage.AssertValidLogin("Log off");
        }
        //Article tetst

        [LogResultToFileAttribute]
        [Test, Property("Article", 1)]
        public void CreateArticleWithEmptyFields()
        {

            CreateArticleNegativeTests(TestContext.CurrentContext.Test.MethodName, "The Title field is required.", "The Content field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Article", 1)]
        public void CreateArticleWithoutTitle()
        {

            CreateArticleNegativeTests(TestContext.CurrentContext.Test.MethodName, "The Title field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("Article", 1)]
        public void CreateArticleWithoutContent()
        {

            CreateArticleNegativeTests(TestContext.CurrentContext.Test.MethodName, "The Content field is required.");

        }
        //article edit
        [LogResultToFileAttribute]
        [Test, Property("Article", 1)]
        public void ArticleEdit()
        {
            

            var loginPage = new LoginPage(driver);
            var loginUser = AccessExcelData.GetLoginTestData("LoginWithValidData");
            loginPage.NavigateTo();
            loginPage.FillLoginForm(loginUser);

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var newArticle = new String(stringChars);

            var editArticle = new ArticlePage(driver);

            editArticle.EditArticle(newArticle);

            editArticle.AssertArticleContent(newArticle);



        }


        // Change Password tests

        [LogResultToFileAttribute]
        [Test, Property("ChangePassword", 1)]
        public void ChangePasswordWithInvalidCurrentPassword()
        {

            ChangePasswordWithNegativeData(TestContext.CurrentContext.Test.MethodName, "Incorrect password.");

        }

        [LogResultToFileAttribute]
        [Test, Property("ChangePassword", 1)]
        public void ChangePasswordWithoutConfirmPassword()
        {

            ChangePasswordWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The new password and confirmation password do not match.");

        }

        [LogResultToFileAttribute]
        [Test, Property("ChangePassword", 1)]
        public void ChangePasswordWithoutNewPassword()
        {
            
            ChangePasswordWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The New password field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("ChangePassword", 1)]
        public void ChangePasswordWithoutCurrentPassword()
        {

            ChangePasswordWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Current password field is required.");

        }

        [LogResultToFileAttribute]
        [Test, Property("ChangePassword", 1)]
        public void ChangePasswordWithoutData()
        {

            ChangePasswordWithNegativeData(TestContext.CurrentContext.Test.MethodName, "The Current password field is required.", "The New password field is required.");

        }

        //page load tests

        [LogResultToFileAttribute]
        [Test]
        public void CheckSiteLoad()
        {
            var site = new Page(this.driver);

            site.NavigateTo();

            site.AssertSiteLogo("SOFTUNI BLOG");

        }

        [LogResultToFileAttribute]
        [Test]
        public void CheckLoadRegistrationPage()
        {
            var regPage = new Page(driver);

            regPage.NavigateTo();
            regPage.CheckRegistrationPage();

            regPage.AssertPageIsOpen("Register");
        }

        [LogResultToFileAttribute]
        [Test]
        public void CheckLoadLoginPage()
        {

            var loginPage = new Page(driver);

            loginPage.NavigateTo();
            loginPage.ClickLoginButton();

            loginPage.AssertPageIsOpen("Log in");
        }
    }
}

