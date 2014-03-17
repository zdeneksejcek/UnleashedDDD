Feature: Register New Organization
	In order to be able to use Unleashed
	As a new registered user
	I want to register new organization and be its owner

Scenario: Organization registering with success
	Given Me as an existing user
	And Organization service initialized
	And I use following data
	| field            | value                                |
	| OwnerId          | 4C3909D2-A58A-4641-B6FA-A1E2F68F471B |
	| OrganizationName | My first organization                |
	When I register
	Then new organization should be registered
	And I am owner of the created organization
	And I should have new account