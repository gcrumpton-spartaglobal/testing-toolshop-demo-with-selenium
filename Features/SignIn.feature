Feature: SignIn

As a user, I want to be able to enter my email address and password, click the login button,
and be taken to my account dashboard.

@happy
Scenario Outline: As an admin, I enter my email address and password and I am taken to my admin dashboard
	Given I am on the sign in page
	When I fill out the sign in form with the following information:
		| Email   | Password   |
		| <email> | <password> |
	And I click "Login"
	Then I am taken to the admin dashboard
Examples: 
	| email                             | password  |
	| admin@practicesoftwaretesting.com | welcome01 |
