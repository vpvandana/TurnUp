Feature: TMFeature

As TurnUp portal admin
I would like to create, edit and delete time and materials record
So that I can manage records successfully

Scenario: Create new Time and Materials record
	Given Launch TurnUp portal and login with valid credentials
	When I navigate to time and material page
	And  I create new time and materials record
	Then new time and material record created successfully

	Scenario Outline: Edit existing time and material record
	Given Launch TurnUp portal and login with valid credentials
	When I navigate to time and material page
	And I update existing time and materials '<Description>' record 
	Then The record has been updated '<Description>'

	Examples: 
	| Description |
	| Materials   |
	| Time        |
	| June2023    |