Feature: Scenarios With Special Characters
  Here we demonstrate usage of special characters in scenario names

Background:
  Given the calculator has clean memory

Scenario: This is a scenario with parentheses, hyphen and comma (10-20, 30-40)
  Given I have entered 50 into the calculator
  And I have entered 70 into the calculator
  When I press add
  Then the result should be 120 on the screen


Scenario Outline: This is a scenario outline with parentheses, hyphen and comma (10-20, 30-40)
  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass_1 |
