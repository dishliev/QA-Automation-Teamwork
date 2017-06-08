using Blog.FunctionalUI.Tests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests.Pages.ChangePaswordPages
{
    public partial class ChangePasswordPage : BasePage
    {
        public ChangePasswordPage(IWebDriver driver) : base(driver)
        {
            AccessExcelData.fileName = "PasswordData.xlsx";
        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Login");
          
        }
        public void NavigateToChangePassword()
        {
            HelloUserButtonMenu.Click();
            ChangeYourPasswordButton.Click();

        }
        public void FillChangePasswordForm(ChangePassword password)
        {
            Type(CurrentPasswordField, password.CurrentPassword);
            Type(NewPasswordField, password.NewPassword);
            Type(ConfirmNewPasswordField, password.ConfirmNewPassword);

            ChangePasswordButton.Click();
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