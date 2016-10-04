Feature: PAYESchemes
	In order to manage PAYE schemes attached
	I need to be able to view, add and remove a PAYE scheme

@PAYESchemes @Regression
Scenario: Add PAYE scheme	
	Given I add a PAYE scheme for "companyNumber"
	Then PAYE scheme is added

@PAYESchemes @Regression
Scenario Outline: View PAYE scheme
	Given I can view a PAYE scheme
	Then I can view a PAYE scheme

@PAYESchemes @Regression
Scenario: Remove PAYE Scheme
	Given I have an account
	When I remove a PAYE scheme
	Then PAYE scheme is removed

