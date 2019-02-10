using FluentAssertions;
using Internship.PageObjects;
using Internship.Utilities;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Internship.StepDefinitions
{
    [Binding]
    public class RegistrationSteps 
    {
        RegistrationPage registration;

        public RegistrationSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I click the register link")]
        public void WhenIClickTheRegisterLink()
        {
            registration.ClickRegister();
        }
        
        [When(@"I enter first name")]
        public void WhenIEnterFirstName()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName();
        }
        
        [When(@"I enter email")]
        public void WhenIEnterEmail()
        {
            registration.EnterEmailAddress("kenst0kes@yahoo.co.uk");
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNo("07777777111");
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword("MyPassword");
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword("MyPassword");
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            registration.ClickSignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(20000);

            //Assert.IsTrue(registration.successMessageIsDisplayed(),"Error Message: Registration failed");

            registration.SuccessMessageIsDisplayed().Should().BeTrue("Error Message: Registration failed");
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string passwordEntered)
        {
            registration.EnterPassword(passwordEntered);
        }

        [When(@"I confirm password ""(.*)""")]
        public void WhenIConfirmPassword(string confirmPasswordEntered)
        {
            registration.EnterConfirmPassword(confirmPasswordEntered);
        }

        [Then(@"the passowrd is too short is displayed")]
        public void ThenThePassowrdIsTooShortIsDisplayed()
        {
            registration.PasswordTooShortMessageIsDisplayed().Should().BeTrue("Password is not too short");
        }

    }
}
