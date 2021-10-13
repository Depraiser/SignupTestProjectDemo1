using OpenQA.Selenium;
using SignupTestProject2.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignupTestProject2.PageObject
{
    class DataDrivenWithParameter
    {
        public DataDrivenWithParameter()
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
        IWebElement Settings => driver.FindElement(By.XPath("/html/body/a"));

        public void ClickOnSignInButton()
        {
            SignInClick();
        }

        private void SignInClick()
        {
            SignIn.Click();
        }

        public void EnterUsername(String UsernameText)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(UsernameText + randomInt);
            //Username.SendKeys(UsernameText);
        }


        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void EnterEmail(string EmailText)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(EmailText + randomInt + "@yahoo.com");
            //Email.SendKeys(EmailText);
        }


        public void EnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }


        public void ClickOnSignUpButton()
        {
            SignUp.Click();

        }


        public bool IsNewArticleDispled()
        {
            return NewArticle.Displayed;
        }


        public bool IsSettingsDispled()
        {
            return Settings.Displayed;
        }


















    }
}
