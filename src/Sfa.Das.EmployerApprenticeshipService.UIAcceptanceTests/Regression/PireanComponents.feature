Feature: PireanComponents
	In order to ensure IDAMS solution is functional
	My tests must pass consistently

@Access @Regression
Scenario: Login
	Given I login Pirean
	Then I close Browser

@Access @Regression
Scenario Outline: Register a Pirean Account
	Given I want to register new user
	When I set New firstname "<firstname>" 
	And  I set New last name"<lastname>"
	And   I set New email "<email>"
	And   I set New password "<password>"
	Then  I click CreateAccount
Examples:
| firstname | lastname | email | password |
|   test        |    test      |   sfa.aml.test+12th@gmail.com    |   Office01       |
	
	
