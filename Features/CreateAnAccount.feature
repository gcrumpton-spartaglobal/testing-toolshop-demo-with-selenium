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
	Examples: 
	| firstName | lastName | dateOfBirth | street        | postalCode | city      | state | country      | phone       | email                  | password         |
	| John      | Smith    | 01/01/1982  | 1 Fake Street | FA65 9AL   | Fake City | Fake  | United Kingdom | 01234567890 | fake.email@hotmail.com | 52x+8=Hc79FjRTQ9 |
	| Sarah-Jane | Smith   | 14/04/1987  | 5 Fake Lane | FA89 9YZ   | Fake City | Fake  | United Kingdom | 01433567790 | sarah.j.smith@hotmail.com | 5W4WHsFL!+b$9!pQ |

@sad
Scenario Outline: I click the "Register" button without filling out the form
	Given I am on the home page
	When I click "Sign In" in the nav bar
	And I click "Register your account"
	And I fill out the form with the following information:
		| FirstName   | LastName   | DateOfBirth   | Street   | PostalCode   | City   | State   | Country   | Phone   | Email   | Password   |
		| <firstName> | <lastName> | <dateOfBirth> | <street> | <postalCode> | <city> | <state> | <country> | <phone> | <email> | <password> |
	And I click on the "Register" button
	Then I receive an error message for each field
	Examples:
	| firstName | lastName | dateOfBirth | street | postalCode | city | state | country | phone | email | password |
	|           |          |             |        |            |      |       |         |       |       |          |

Scenario Outline: I try to create various valid and invalid passwords
	Given I am on the home page
	When I click "Sign In" in the nav bar
	And I click "Register your account"
	And I fill out the form with the following information:
		| FirstName | LastName | DateOfBirth | Street | PostalCode | City | State | Country | Phone | Email | Password |
		| <firstName> | <lastName> | <dateOfBirth> | <street> | <postalCode> | <city> | <state> | <country> | <phone> | <email> | <password> |
	And I click on the "Register" button
	Then The password is either valid or invalid
	Examples:
	| firstName | lastName | dateOfBirth | street        | postalCode | city      | state | country        | phone       | email                  | password |
	| John      | Smith    | 01/01/1982  | 1 Fake Street | FA65 9AL   | Fake City | Fake  | United Kingdom | 01234567890 | fake.email@hotmail.com |          |
	| John      | Smith    | 01/01/1982  | 1 Fake Street | FA65 9AL   | Fake City | Fake  | United Kingdom | 01234567890 | fake.email@hotmail.com | P        |
	| John      | Smith    | 01/01/1982  | 1 Fake Street | FA65 9AL   | Fake City | Fake  | United Kingdom | 01234567890 | fake.email@hotmail.com | Passwor  |
	| John      | Smith    | 01/01/1982  | 1 Fake Street | FA65 9AL   | Fake City | Fake  | United Kingdom | 01234567890 | fake.email@hotmail.com | Egj@svn1 |
