Feature: Search using Google
    Searching for saucedemo on Google
	Tests for LogIn with more solutions

@LoginTestsClear
Scenario: Clear input LogIn
    Given Navigate to the Swag Labs LogIn page
    Then LogIn button is clicked Error message should apper
    And Close the browser

@LoginTestsWrongUser
Scenario: Wrong input LogIn
    Given Navigate to the Swag Labs LogIn page
    Then Input wrong_user in thextbox Username
    And Input bad_sauce in textbox Password
    Then LogIn button is clicked Error message should apper
    And Close the browser

@LoginTestsCorrectUser
Scenario: Correct input LogIn
    Given Navigate to the Swag Labs LogIn page
    Then Input standard_user in thextbox Username
    And Input secret_sauce in textbox Password
    Then LogIn button is clicked and Swag Labs Home Page appears
    And Should add Sauce Labs Backpack to cart
    And Should add Sauce Labs Fleece Jacket to cart
    Then Click on Shopping cart should open Your cart with products
    When Click on Checkout button should Checkout informations page open
    And Input secret in textbox First Name
    And Input sauce in textbox Last Name
    And Input 32351 in thextbox Zip/Postal Code
    When Click on Checkout button should Overview page open
    When Click on Finish button should Checkout:Complete! page open
    Then Click Back Home button should open Home Page with products
    And Close the browser