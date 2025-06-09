Feature: SendContactForm

As a user, I want to be able to navigate to the contact page, fill out a contact form, 
and submit it to receive a confirmation message.

@happy
Scenario Outline: I fill out the contact form with valid information and receive a confirmation message
	Given I am on the contact page
	When I fill out the contact form with the following information:
		| FirstName   | LastName   | Email   | Subject   | Message   |
		| <firstName> | <lastName> | <email> | <subject> | <message> |
	And I click on the "Send" button
	Then I receive a confirmation message
	Examples: 
	| firstName | lastName | email              | subject  | message                                                                                                                                                                                                                                   |
	| John      | Doe      | john.doe@gmail.com | "Return" | "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." |

@sad
Scenario Outline: I try to submit the contact form with no entered information
	Given I am on the contact page
	When I fill out the contact form with the following information:
		| FirstName   | LastName   | Email   | Subject   | Message   |
		| <firstName> | <lastName> | <email> | <subject> | <message> |
	And I click on the "Send" button
	Then I receive an error message for each field on the contact form
	Examples: 
	| firstName | lastName | email | subject | message |
	|           |          |       |         |         |

Scenario Outline: I try to submit the contact form with various message lengths
	Given I am on the contact page
	When I fill out the contact form with the following information:
		| FirstName   | LastName   | Email   | Subject   | Message   |
		| <firstName> | <lastName> | <email> | <subject> | <message> |
	And I click on the "Send" button
	Then I receive an error or success message
	Examples: 
	| firstName | lastName | email              | subject  | message                                                                                                                                                                                                                                                       |
	| John      | Doe      | john.doe@gmail.com | "Return" |                                                                                                                                                                                                                                                               |
	| John      | Doe      | john.doe@gmail.com | "Return" | "L"                                                                                                                                                                                                                                                           |
	| John      | Doe      | john.doe@gmail.com | "Return" | "Lorem ipsum dolor sit amet, consectetuer adipisci"                                                                                                                                                                                                           |
	| John      | Doe      | john.doe@gmail.com | "Return" | "Lorem ipsum dolor sit amet, consectetuer adipiscin"                                                                                                                                                                                                          |
	| John      | Doe      | john.doe@gmail.com | "Return" | "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium."  |
	| John      | Doe      | john.doe@gmail.com | "Return" | "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium q" |

