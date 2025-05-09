Feature: CheckHomePageTitle

As a developer, I want to check that the website title is correct,
so that users see that they are on the correct website.

Scenario: Check website title while on the home page 
	Given I am on the home page
	When I check the title
	Then the title should be "Practice Software Testing - Toolshop - v5.0"
