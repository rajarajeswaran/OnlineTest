Feature: Question
	

Scenario Outline: Create Question
	Given I have Question <Title> 
	And I have OptionA <OptionATitle> 
	And I have OptionB <OptionBTitle> 
	And I have OptionC <OptionCTitle> 
	And I have OptionD <OptionDTitle> 
	And I have Answer <AnswerTitle> 
	And I Save it
	When I Query by Question <Title> 
	Then the result should be a valid Question Model

	Examples: 
	| Title                         | OptionATitle                    | OptionBTitle               | OptionCTitle                   | OptionDTitle           | AnswerTitle            |
	| You may drive over a footpath | to overtake slow-moving traffic | if no pedestrians are near | when the pavement is very wide | to get into a property | to get into a property |







