Feature: Login3

A short summary of the feature

@Login_into_w3Schools 
Scenario Outline: Successfull Login with Valid Credentials
	Given  Navigate user to LogIn Page
	When User enter UserName<UserName> and Password<Password>
	And Click on the LogIn button
	Then Successful LogIN message should display
	@source:Credentials.xlsx
	Examples:
	    | UserName | Password |