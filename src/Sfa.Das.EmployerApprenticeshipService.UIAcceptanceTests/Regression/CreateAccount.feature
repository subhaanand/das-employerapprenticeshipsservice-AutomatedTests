Feature: CreateAccount
	In order to use AML
	I need to be able to create an employer account

@Regression
Scenario: Create Employer Account
	
	Given I navigated to the Start page
	Then  I see 
	| Field       | Rule   | Value |
	| UserNameBox | exists | true  |
	| PasswordBox | exists | true  |
	| LoginButton | exists | true  |
	Then I enter data
	| Field       | Value                  |
	| UserNameBox | sfa.aml.test+Jane@gmail.com |
	| PasswordBox | Office01               |
	When I choose LoginButton
	
	Then I wait to see CreateNewEmployerAccount
	When I choose CreateNewEmployerAccount
	Then I am on the InformGuidance page
	And I see
    | Field | Rule | Value |
    | PageHeading   |equals   |Register your apprenticeship account|
	When I choose StartAccountCreationButton
	And I wait for the view to become active
	Then I am on the GovernmentGatewayConfirm page
	When I choose YesOption
	And I choose ContinueButton
	Then I am on the SearchForCompany page
	When I wait for the view to become active
	And I enter data
	| Field                     | Value    |
	| CompanyHouseNumberTextBox | 10284352 |
	When I choose ContinueButton
	And I wait for the view to become active	
	Then I see 
	| Field          | Rule     | Value                     |
	| PageHeading    | contains | Confirm your company name |
	| AddCompanyToContractButton | exists   | true                      |
	When I choose AddCompanyToContractButton
	And I wait for the view to become active
	Then I see
	| Field            | Rule   | Value |
	| HMRCUserNameBox  | exists | true  |
	| HMRCPasswordBox  | exists | true  |
	| HMRCSignInButton | exists | true  |
	And I enter data
    | Field           | Value     |
    | HMRCUserNameBox | user1     |
    | HMRCPasswordBox | password1 |
	When I choose HMRCSignInButton
	And I wait for the view to become active
	Then I see
	| Field                | Rule     | Value                                          |
	#| PageHeading          | contains | Authority to interact with HMRC on your behalf |
	| GrantAuthorityButton | exists   | true                                           |
	When I choose GrantAuthorityButton
	And I wait for the view to become active
	Then I am on the EmployerSummary page
	When I choose YesOption
	And I choose ContinueButton

Scenario: Load Start Page
Given I navigated to the Start page