Feature: OddsFormat

As as user of the sportsbook website
I want to be able to change the format of the odds from Fractional, Decimal, and American styles
So that I will be able to browse odds in my preferred style

Background: Open the Homepage, maximise, and close the Cookie Confirmation
	Given I have opened the Homepage

	# Change odds format and look for a particular character in the first odds found on the page
Scenario Outline: Change the format of the odds dispayed on the Homepage
	Given I am browsing odds on the Homepage
	When I select the '<OddsStyle>' of odds
	Then the odds on the page should now be displayed with the expected '<Format>'

	Scenarios:
	| OddsStyle | Format |
	| Fraction  | /      |
	| Decimal   | .      |
	| American  | +      |
