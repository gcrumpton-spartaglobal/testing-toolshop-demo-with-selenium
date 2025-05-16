Feature: CreateAnAccount

As a user, I want to be able to navigate to the sign in page, click "Register your account",
and be redirected to a page containing a form that I can fill out, submit, and then be taken 
back to the sign in page.

@happy
Scenario Outline: I fill out the form with valid information and an account is created
	Given I am on the home page
	When I click "Sign In" in the nav bar
	And I click "Register your account"
	And I fill out the form with the following information:
		| FirstName  | LastName  | DateOfBirth | Street   |  PostalCode  | City   | State   | Country   | Phone   | Email   | Password |
		| <firstName> | <lastName> | <dateOfBirth> | <street> |  <postalCode> | <city> | <state> | <country> | <phone> | <email> | <password> |
	And I click on the "Register" button
	Then I am taken to the sign in page
