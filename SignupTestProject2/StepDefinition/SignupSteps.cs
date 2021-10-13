using NUnit.Framework;
using SignupTestProject2.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SignupTestProject2.StepDefinition
{
    [Binding]
    public class SignupSteps
    {
        SignupPage signupPage;

        public SignupSteps()
        {
            signupPage = new SignupPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signupPage.NavigateToWebsite();
        }
        


        [Given(@"I click on sign in Button")]
        public void GivenIClickOnSignInButton()
        {
            signupPage.ClickOnSignInButton();
        }
        


        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            signupPage.EnterUsername();
        }
        


        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            signupPage.EnterEmail();
        }
        


        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            signupPage.EnterPassword();
        }


        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            signupPage.ClickOnSignUpButton();
        }
        



        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);

            Assert.That(signupPage.IsNewArticleDispled);
        }

        [Then(@"I should be able to register successfully on the page")]
        public void ThenIShouldBeAbleToRegisterSuccessfullyOnThePage()
        {
            Thread.Sleep(5000);
            Assert.That(signupPage.IsNewArticleDispled);
        }

    }
}
