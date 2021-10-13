Feature: Signup
	In order to use all the benefits on the website
	I will need to sign up first

@mytag
Scenario: Valid Signup Test
	Given I navigate to the website
	And I click on sign in Button
	And I enter my username
	And I enter my email address
	And I enter my password
	When I click on sign up button
	Then I should be able to register successfully
	Then I should be able to register successfully on the page