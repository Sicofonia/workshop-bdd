Feature: CalculateOrderTotalForGermany
	In order to launch in Germany
	As an international seller
	I want to be able to calculate tax in Germany

@mytag
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