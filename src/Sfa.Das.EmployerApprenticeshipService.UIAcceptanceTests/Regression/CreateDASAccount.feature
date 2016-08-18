Feature: CreateDASAccount
	In order to access my Levy account
	I need to be able to create a DAS account

@mytag
Scenario: Create DAS Account
	Given I login Pirean
	When I Create a DAS Account
	Then An account should be "created"
