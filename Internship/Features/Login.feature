Feature: Login
	As a registered user of gittrete
	I would like to login
	So that I can use the site

@mytag
Scenario: Login to the site
	Given I navigate to the site
	When I click on Login link
	And I enter email 
	And I enter password
	And I click on secure sign in button
	Then i am logged in to the site
