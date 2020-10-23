#Feature: Calculator
#	In order to avoid silly mistakes
#	As a math idiot
#	I want to be told the sum of two numbers
#
#@mytag
#Scenario: Add two numbers
#	Given the first number is 50
#	And the second number is 70
#	When the two numbers are added
#	Then the result should be 120

Feature: Solution Setup
	In order to make sure the app is ready to go
	As a dev
	I want to call a method from the calculator project

@mytag
Scenario: Dummy test
	Given the project is setup
	Then the test is passing