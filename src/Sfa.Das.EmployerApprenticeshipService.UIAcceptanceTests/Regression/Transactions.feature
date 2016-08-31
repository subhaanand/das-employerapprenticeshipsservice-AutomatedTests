Feature: Transactions
	In order to track my Levy spending
	I need an accurate view of my transactions

@TransactionsView @Regression
Scenario: View a Transaction
	Given I view transactions
	Then Transactions page is displayed
