using Internship.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='signup-form']/div[5]/label[2]")]
        private IWebElement passwordTooShortMessage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement successMessage { get; set; }

        public bool PasswordTooShortMessageIsDisplayed()
        {
            try
            {
                return passwordTooShortMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool SuccessMessageIsDisplayed()
        {
            try
            {
                return successMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
 
        public void ClickSignUp()
        {
            signUp.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("ken");
        }

        public void EnterLastName()
        {
            lastName.SendKeys("stokes");
        }

        public void EnterMobileNo(string mobileno)
        {
            mobileNo.SendKeys(mobileno);
        }

        public void EnterPassword(string Password)
        {
            password.SendKeys(Password);
        }

        public void EnterConfirmPassword(string ConfirmPassword)
        {
            confirmPassword.SendKeys(ConfirmPassword);
        }

        public void ClickRegister()
        {
            register.Click();
        }

        public void EnterEmailAddress(string MyEmail)
        {
            emailAddress.SendKeys(MyEmail);
        }

    



    }
}
