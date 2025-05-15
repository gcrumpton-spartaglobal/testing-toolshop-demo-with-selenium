Feature: AddToCartFromHomePage

As a potential customer, I want to be able to add items to my cart from the home page,
so that I can easily purchase items without navigating to a product page.

Scenario: Add "Claw Hammer" to cart from home page
	Given I am on the home page
	When I scroll to the "Claw Hammer" product
	And I click on the "Claw Hammer" card
	And I click the add to cart button
	Then I receive a pop-up saying "Product added to shopping cart."

Scenario: Add "Pliers" to the cart from the home page with "Claw Hammer" already in the cart
	Given I am on the home page
	When I scroll to the "Claw Hammer" product
	And I click on the "Claw Hammer" card
	And I click the add to cart button
	And I click the browser back button
	And I search for "pliers" in the search bar
	And I scroll to the "Pliers" product
	And I click on the "Pliers" card
	And I click the add to cart button
	And I click on the cart icon
	Then I should see the added items in the cart
	And The price total should be $23.49
