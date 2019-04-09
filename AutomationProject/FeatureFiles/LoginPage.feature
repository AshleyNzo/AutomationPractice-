Feature: LoginTest
	In order to get to the 
	login page we going bruh 

@SmokeTest
Scenario: LoginPage
	Given I am on the homepage
	When I click signin
	Then I should be on the signin page 