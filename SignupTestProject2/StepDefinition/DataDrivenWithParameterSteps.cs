using SignupTestProject2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SignupTestProject2.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
    
       
            DataDrivenWithParameter dataDrivenWithParameter;

            public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameter = new DataDrivenWithParameter();
        }








            [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameter.NavigateToWebsite(url);
        }
        
        [Given(@"I enter username test ""(.*)""")]
        public void GivenIEnterUsernameTest(string UsernameText)
        {
            dataDrivenWithParameter.EnterUsername(UsernameText);
        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string EmailText)
        {
            dataDrivenWithParameter.EnterEmail(EmailText);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string PasswordTest)
        {
            dataDrivenWithParameter.EnterPassword(PasswordTest);
        }
    }
}
