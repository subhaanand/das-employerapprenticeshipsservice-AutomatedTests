Feature: CancelInvitation
In order to change my mind about membership
	I need to be able to cancel an invitation provided it has not been accepted

@Regression
Scenario: Cancel Invitation
Given I navigated to the Start page
Then I enter data
	| Field       | Value						|
	| UserNameBox | sfa.aml.test+Jane@gmail.com |
	| PasswordBox | Office01					|
	When I choose LoginButton
	And I wait for the view to become active	   
	When I choose openAccountLink
	And I wait for the view to become active
	Then I am on the EmployerAccountView page	
	When I choose TeamLink
	Then I am on the TeamView page
	When I choose ViewLinkJohn
	Then I am on the TeamMemberReview page
	#And I see 
	#| Field                 | Rule   | Value |
	#| CancelInvitationButton| exists | true  |