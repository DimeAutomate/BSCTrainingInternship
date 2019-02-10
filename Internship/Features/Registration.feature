Feature: Registration
	As a user of the site
	I would like to register
	So that I can login to the site

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	When I click the register link
	And I enter first name
	And I enter last name
	And I enter email
	And I enter mobile number
	And I enter password
	And I confirm password
	And I click on signup
	Then I should be registered

	Scenario: Invalid Registration Password Too Short
	Given I navigate to the site
	When I click the register link
	And I enter first name
	And I enter last name
	And I enter email
	And I enter mobile number
	And I enter password "MyVaryingPassword"
	And I confirm password "None"
	#And I click on signup
	Then the passowrd is too short is displayed
	Then I should be registered


