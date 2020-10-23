Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Calculate the total price from quantity
	Given the price is 100
	And the quantity is 5
	Then the priceresult should be 500

Scenario: Calculate the total price inclusive of DE tax
	Given the decountry is DE
	And the deprice is 100
	And the dequantity is 5
	Then the deresult should be 531.25

Scenario: Calculate the total price inclusive of FR tax
	Given the frcountry is FR
	And the frprice is 100
	And the frquantity is 5
	Then the frresult should be 540

Scenario: Calculate the total price inclusive of PT tax
	Given the ptcountry is PT
	And the ptprice is 100
	And the ptquantity is 5
	Then the ptresult should be 534.25	