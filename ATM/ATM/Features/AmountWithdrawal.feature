Feature: AmountWithdrawal
	Current Amount and Withdraw

@mytag
Scenario: Current amount after Withdraw
	Given Amount in Account
	And Enter the choice
	And Withdraw the amount
	When Validate the Pin	 
	Then Your current amount