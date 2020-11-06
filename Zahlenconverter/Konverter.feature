Feature: Konverter
	As a  nerd
	I want to koncert strings to integer

@mytag
Scenario: hex
	Given the srtig is <affe>
	When the the string gets converted with base sixteen
	Then the result should be 45054

@mytag
Scenario: oct 
	Given the srtig is <11147>
	When the the string gets converted with base eight
	Then the result should be 4711

	@mytag
Scenario:bin 
	Given the srtig is <1100>
	When the the string gets converted with base two
	Then the result should be 12