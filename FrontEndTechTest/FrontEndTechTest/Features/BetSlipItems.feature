Feature: BetSlipItems

As as user of the sportsbook website
I want to be able to add and remove items from my betslip
So that I will be able to place a bet

Background: Open the Homepage, maximise, and close the Cookie Confirmation
	Given I have opened the Homepage

	# Check the betslip is empty, add the first bet on the page, and check the betlsip counter
Scenario: Add an item to the betslip
	Given the betslip is empty
	When I add an item to my betslip
	Then the item is placed in my betslip

	# Check the betslip is empty, add the first bet on the page, then remove it, and check the betslip counter
Scenario: Add an item to the betslip, then remove it
	Given the betslip is empty
	When I add an item to my betslip
	And then I remove it
	Then the betslip is empty
