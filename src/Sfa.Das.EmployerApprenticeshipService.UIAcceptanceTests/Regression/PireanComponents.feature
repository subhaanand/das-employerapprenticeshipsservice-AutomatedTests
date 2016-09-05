Feature: PireanComponents
	In order to ensure IDAMS solution is functional
	My tests must pass consistently

@Access
Scenario: Login
	Given I login Pirean
	Then I close Browser
Scenario Outline: Register a Pirean Account
	Given I want to register new user
	Given I set New firstname "<firstname>" 
	And I set New last name"<lastname>"
	And I set New email "<email>"
	And I set New password "<password>"
	Then I click CreateAccount
Examples:
| firstname | lastname | email | password |
|           |          |       |          |
	
	
