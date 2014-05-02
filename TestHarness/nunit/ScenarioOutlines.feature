Feature: Scenario Outlines
  Here we demonstrate how we deal with scenario outlines

Scenario Outline: This is a scenario outline where all scenarios pass 
  
  This means the entire scenario outline passes.
  
  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass_1 |
    | pass_2 |
    | pass_3 |

    
Scenario Outline: This is a scenario outline where one scenario is inconclusive
  
  This means the entire scenario outline is inconclusive.

  Then the scenario will '<result>'

  Examples: 
    | result         |
    | pass_1         |
    | pass_2         |
    | inconclusive_1 |


Scenario Outline: This is a scenario outline where one scenario fails
  
  This means the entire scenario outline fails.

  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass_1 |
    | pass_2 |
    | fail_1 |


Scenario Outline: And we can go totally bonkers with multiple example sections.

  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass_1 |
    | pass_2 |

  Examples: 
    | result         |
    | inconclusive_1 |
    | inconclusive_2 |

  Examples: 
    | result |
    | fail_1 |
    | fail_2 |
