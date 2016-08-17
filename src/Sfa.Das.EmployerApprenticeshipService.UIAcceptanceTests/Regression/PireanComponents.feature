Feature: PireanComponents
	In order to ensure IDAMS solution is functional
	My tests must pass consistently

@BugRetest
Scenario: LoadPireanPage
	Given I load Pirean
	When I refresh the page
	Then Pirean Login Page is Titled "Sign in"
	
