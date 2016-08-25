Feature: Transactions
	In order to track my Levy spending
	I need an accurate view of my transactions

@TransactionsView @Regression
Scenario: View a Transaction
	Given I have an account
	When I view a monthly transaction
	Then a detailed view is displayed
