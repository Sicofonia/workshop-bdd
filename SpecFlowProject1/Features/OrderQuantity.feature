﻿Feature: OrderQuantity
	In order to calculate order total
	As a retail clerk
	I want to calculate the order total based on price and quantity

@mytag
Scenario: Calculate total order
	Given that the quantity is <quantity>
	And the price is <price>
	When the i calculate the order total
	Then the result should be <result>

	Examples:
    | quantity | price | result |
    | 10       | 2     | 20     |
    | 10       | 2.5   | 25     |



Scenario: Calculate total order
	Given that the quantity is <quantity>
	And the price is <price>
	And the country code is <countryCode>
	When the i calculate the order total
	Then the result should be <result>

	Examples:
    | quantity | price | countryCode | result |
    | 100      | 1     | DE          | 106.25 |
    | 100      | 1     | de          | 106.25 |
	| 100      | 1     | De          | 106.25 |
	| 100      | 1     | FR          | 100    |