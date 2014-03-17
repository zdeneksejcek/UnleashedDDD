Feature: Register New User
	In order to use unleashed application
	As a anonymous
	I want to register new user account

Scenario: Registering with valid details
	Given I have RegisterNewUserservice initialized
	When I use following data
	| field     | value        |
	| FirstName | John         |
	| LastName  | Doe          |
	| Email     | john@doe.com |
	And register
	Then I should have new account