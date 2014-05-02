Feature: Scenario Outlines
  Here we demonstrate how we deal with scenario outlines

Scenario Outline: This is a scenario outline where all scenarios pass 
  
  This means the entire scenario outline passes.
  
  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass 1 |
    | pass 2 |
    | pass 3 |

    
Scenario Outline: This is a scenario outline where one scenario is inconclusive
  
  This means the entire scenario outline is inconclusive.

  Then the scenario will '<result>'

  Examples: 
    | result         |
    | pass         1 |
    | pass         2 |
    | inconclusive 1 |


Scenario Outline: This is a scenario outline where one scenario fails
  
  This means the entire scenario outline fails.

  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass 1 |
    | pass 2 |
    | fail 1 |


Scenario Outline: And we can go totally bonkers with multiple example sections.

  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass 1 |
    | pass 2 |

  Examples: 
    | result         |
    | inconclusive 1 |
    | inconclusive 2 |

  Examples: 
    | result |
    | fail 1 |
    | fail 2 |
