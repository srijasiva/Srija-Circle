Feature: To check a consultants availability for desired Location and Date 

For a Given Location and Date, check a consultants availability to make my decision

Background:
	Given Open the browser
	When Enter the URL	
	Then I should see the Circle Health Homepage

@ConsultantAvailablity
Scenario: To check a consultants availability 	
	
	Given I am in CircleHealth Homepage
	When I click Find a treatment button
	And I enter Knee replacement surgery in Search for a treatment searchbar 
	And I click Search Button
	And I click Book an appointment in Knee replacement surgery search Results
	And I click Use current location in Location search
	And I click Search Button
	And I click September 28, 2023 in Appointment Calender
	Then I verify consultants availability and location provided to make my decision
