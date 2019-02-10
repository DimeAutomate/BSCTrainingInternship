using Internship.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Internship.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
        }

        [When(@"I click on Login link")]
        public void WhenIClickOnLoginLink()
        {
           loginPage.ClickLogin();
        }
        
        [When(@"I click on secure sign in button")]
        public void WhenIClickOnSecureSignInButton()
        {
            loginPage.ClickSignin();
        }

        [Then(@"i am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            loginPage.ClickWelcomeLink();
        }
    }
}
