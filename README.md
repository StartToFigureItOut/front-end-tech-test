# Frontend Technical Test - Alex Murphy

Thank you for looking at my submission for the Stars Group technical test.

As instructed, I completed the task using C#, as that is the language I am most familiar with. I don't know Cypress (yet!) but I did use Specflow which is a port of Cucumber.

The test scenarios can be found in the Specflow feature files located in the Specflow folder (BetSlipItems.feature and OddsFormat.feature).

### BetSlipItems.feature
This feature file contains 2 simple scenarios to give the Betslip a quick test. The first adds an item to the betslip and checks that the betslip counter is updated. The second does the same, then removes the item and checks that the betslip counter is reset to 0. In each case it gets the first bet that it finds on the page.

### OddsFormat.feature
This feature file contains 1 Scenario Outline with a simple table. It sets the format of the odds, then checks that an expected character is found in the first odds that are found on the page.

### Instructions to run

Dependencies:
- Chrome browser
- Visual Studio (Community Edition is fine)
- Install Specflow Extension for Visual Studio

Steps:
- Open Solution in Visual Studio
- Build Solution
- Run tests via Test Explorer

I *think* the above steps would work on a Mac, but I'm not 100% sure.

I recorded a [video of the tests](https://youtu.be/FmsK2vmsSHQ) running, in case this was useful.

### Further information and notes

The project was built using the tools that I'm most familiar with, which is C#, Selenium, Specflow, and a few other packages. It's based around the way that I've been doing things in my current role.

I'm happy with it as a first pass at meeting the criteria of the tests. It is basic and there are things that could be improved. It was a balance between getting something up and running and working, and trying to make a framework that could, in theory, be fleshed out further.

The site was definitely more dynamic than the sites I have tested in my current role!

*Original text below*
-----------------------------------------------------

# Frontend Technical Test

Welcome to The Stars Group technical test for frontend test engineers!

These tasks are open ended but we recommend that you spend no more than a few hours on them.

The site we would like you to test can be found at: https://www.pokerstarssports.uk. Please bear in mind that the site is highly dynamic and both the content and the layout may change over time. You will not need to register an account or log in to the website to complete this test.

### Task 1
Write a number of BDD scenarios using Gherkin to test the following features:
- Adding things to, and removing things from, the bet slip
- Changing the odds format

### Task 2
Create a simple test framework using NPM, Cypress and Cucumber to automate a selection of the scenarios you have created. You should include at least two scenarios from each feature.
- https://www.npmjs.com
- https://www.cypress.io
- https://www.npmjs.com/package/cypress-cucumber-preprocessor


After completing the tasks, please update the README.md file with your scenarios from Task 1 and instructions on how to run your tests, include any information you think is relevant, interesting or useful. The preferred delivery method for this project is via Github but we will also accept a zipped file sent as an email attachment.