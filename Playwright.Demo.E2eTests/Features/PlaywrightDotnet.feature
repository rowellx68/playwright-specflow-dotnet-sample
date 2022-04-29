Feature: Home Page

Scenario: User lands on the homepage and sees the hero banner
  Given I am a visitor
  When I enter the homepage
  Then I should see 'Playwright enables reliable end-to-end testing for modern web apps.'
  Then I should see the Get Started link