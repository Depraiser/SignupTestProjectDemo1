Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	Copy correct
	And carefully

@mytag
Scenario: Data Driven With Parameter
Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sign in Button
	And I enter username test "depraiserguru1"
	And I enter my email address "depraiserguru1"
	And I enter my password "DemoDemoDemo"
	When I click on sign up button
	Then I should be able to register successfully