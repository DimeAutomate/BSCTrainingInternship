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
    public class LoginPage : Hooks
    {

        [FindsBy(How = How.ClassName, Using = "dropdown-toggle")]
        private IWebElement welcomeLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin { get; set; }

        public LoginPage()
        {
            PageFactory.InitElements(Driver, this);
        }
        //Assuming if the dropdown welcome message is found then login is successful
        //The greeting/welcome message can only be present after a successful login
        //There may be better ways to assert this but this is what I could come up with within the time available
        //Will welcome suggestion on better ways to do this please
        public void ClickWelcomeLink()
        {
          welcomeLink.Click();
                                 
        }

        public void ClickSignin()
        {
            signin.Click();
        }
        public void ClickLogin()
        {
            login.Click();
        }
    }
}
