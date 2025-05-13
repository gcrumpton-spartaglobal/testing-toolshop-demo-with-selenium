Feature: AddToCartFromHomePage

As a potential customer, I want to be able to add items to my cart from the home page,
so that I can easily purchase items without navigating to a product page.

Scenario: Add "Claw Hammer" to cart from home page
	Given I am on the home page
	When I scroll to the "Claw Hammer" product
	And I click on the "Claw Hammer" card
	And I click the add to cart button
	Then I receive a pop-up saying "Product added to shopping cart."
