# Automated Testing using Selenium

## Description
C# program to test automatically the first name, last name and mobile field in the web app using selenium.

## Problem Statement
Write a program or algorithm using C# and Selenium to automatically test any three fields on that page.
The main goal of your program is to make sure it still works even if the position or any other properties of the HTML elements for those three fields change.

## Approach

I used `Selenium.Chrome` as a web driver and `Selenium` package for this project. As a first step, I setup the testing environment in chrome by navigating to the url `https://app.cloudqa.io/home/AutomationPracticeForm`.

I choose three fields such as first name, last name and mobile number to test in the web page. I defined separate `Test Field`, the element can be found using their name in the webpage. For example, first name input element can be found with the name `First Name` and it is similar to other fields. Once the field is found, I send keys to the input field, then in the next line I will check whether the expected value is written on the input field or not. If the expected and observed values are different the test fail otherwise it pass.

## Output
All the tests are passed to check all three fields on the web page.

![Tests passed successfully](https://github.com/user-attachments/assets/07d31625-1f18-4f40-82ea-c47aca52d708)

**Thank you!**
