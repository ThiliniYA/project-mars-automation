Feature: Mars Login
  As a registered user
  I want to log into the Mars platform
  So that I can access my profile and manage my skills and languages

  Scenario: Successful login to Mars
    Given I am on the Mars login page
    When I enter Mars email "test@example.com" and password "Password123"
    And I click the Mars login button
    Then I should be logged into Mars successfully
