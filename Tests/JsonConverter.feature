Feature: JsonConverter

@mytag
Scenario: convert CSV to JSON
	Given the next table representation of csv file
	| nombre | apellido  | edad |
	| nexer  | rodriguez | 21   |
	| kevin  | estevez   | 21   |
	| tonio  | mejia     | 20   |
	| josue  | barahona  | 21   |
	When I press convert to Json
	Then the result should be '[{"nombre":"nexer","apellido":"rodriguez","edad":21},{"nombre":"kevin","apellido":"estevez","edad":21},{"nombre":"tonio","apellido":"mejia","edad":20},{"nombre":"josue","apellido":"barahona","edad":21}]'
