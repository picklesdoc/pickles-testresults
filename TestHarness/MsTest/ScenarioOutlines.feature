Feature: Scenario Outlines
  Here we demonstrate how we deal with scenario outlines

Scenario Outline: This is a scenario outline where all scenarios pass 
  
  This means the entire scenario outline passes.
  
  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass   |
    | pass   |
    | pass   |

    
Scenario Outline: This is a scenario outline where one scenario is inconclusive
  
  This means the entire scenario outline is inconclusive.

  Then the scenario will '<result>'

  Examples: 
    | result       |
    | pass         |
    | pass         |
    | inconclusive |


Scenario Outline: This is a scenario outline where one scenario fails
  
  This means the entire scenario outline fails.

  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass   |
    | pass   |
    | fail   |


Scenario Outline: And we can go totally bonkers with multiple example sections.

  Then the scenario will '<result>'

  Examples: 
    | result |
    | pass   |
    | pass   |

  Examples: 
    | result       |
    | inconclusive |
    | inconclusive |

  Examples: 
    | result |
    | fail   |
    | fail   |
