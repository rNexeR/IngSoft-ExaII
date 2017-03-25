Feature: XMLConverter

@mytag
Scenario: convert CSV to XML
	Given the next table of csv representation file
	| nombre | apellido  | edad |
	| nexer  | rodriguez | 21   |
	| kevin  | estevez   | 21   |
	| tonio  | mejia     | 20   |
	| josue  | barahona  | 21   |
	When I press convert to XML
	Then the final result should be '<Rows><Row><nombre>nexer</nombre><apellido>rodriguez</apellido><edad>21</edad></Row><Row><nombre>kevin</nombre><apellido>estevez</apellido><edad>21</edad></Row><Row><nombre>tonio</nombre><apellido>mejia</apellido><edad>20</edad></Row><Row><nombre>josue</nombre><apellido>barahona</apellido><edad>21</edad></Row></Rows>'
	
	
	
	
