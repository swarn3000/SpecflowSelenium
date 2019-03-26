Feature: FormFill
	In order to fill two fields

@mytag
Scenario: Fill the user form
	Given I am on the user form page
	When I fill firstname "Swarn" and fill the middlename "Singh" in the fields
	Then I close browser
