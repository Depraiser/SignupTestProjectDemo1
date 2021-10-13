using OpenQA.Selenium;
using SignupTestProject2.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignupTestProject2.PageObject
{
    class SignupPage
    {
        public SignupPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignIn => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));

        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        IWebElement SignUp => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement NewArticle => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(2) > a"));


        public void ClickOnSignInButton()
        {
            SignInClick();
        }

        private void SignInClick()
        {
            SignIn.Click();
        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys("TestAutomation" + randomInt);
            //Username.SendKeys("TestAutomationGroupGto");
        }


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }


        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys("fawehinmitosin" + randomInt + "@yahoo.com");
            //Email.SendKeys("fawehinmitosin");
        }


        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }


        public void ClickOnSignUpButton()
        {
            SignUp.Click();

        }


        public bool IsNewArticleDispled()
        {
            return NewArticle.Displayed;
        }

    }
}
