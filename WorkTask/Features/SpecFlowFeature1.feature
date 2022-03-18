Feature: Search using Google
    Searching for saucedemo on Google
	Tests for LogIn with more solutions

@LoginTestsClear
Scenario: Clear input LogIn
    Given Navigate to the Swag Labs LogIn page
    And Leave Username and Password textboxes empty
    When I click the LogIn button
    Then Error message should appear
    And Close the browser

@LoginTestsWrongUser
Scenario: Wrong input LogIn
    Given Navigate to the Swag Labs LogIn page
    Then Input "wrong_user" in thextbox "Username"
    And Input "bad_sauce" in textbox "Password"
    Then click the LogIn button
    When LogIn button is clicked
    Then Error message should apper
    And Close the browser

@LoginTestsCorrectUser
Scenario: Correct input LogIn
    Given Navigate to the Swag Labs LogIn page
    Then Input "standard_user" in thextbox Username
    And Input "secret_sauce" in textbox Password
    When LogIn button is clicked
    Then Swag Labs Home Page should appear
    And Should add "Sauce Labs Backpack" to cart
    And Should add "Sauce Labs Fleece Jacket" to cart
    Then Should open "Your cart" with items
    And Click "Checkout" button
    Then Should "Checkout informations" page open
    And Input "secret" in textbox "First Name"
    And Input "sauce" in textbox "Last Name"
    And Input "32351" in thextbox "Zip/Postal Code"
    And click "Checkout" button
    Then Should "Overview" page appear
    And click "Finish" button
    Then Should "Checkout:Complete" page appear
    And click "Back Home" button
    Then Should Home Page with products appear
    And close the browser