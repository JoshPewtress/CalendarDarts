# CalendarDarts
A skill check program for C#, with a focus on working with dates.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Logic Breakdown / Tasks](#logic-breakdown--tasks)
- [Code Structure](#code-structure)

## Overview
This project demonstrates fundamental C# concepts including:
- Working with Date objects
- Random number generation
- DateTime comparisons
- Object Oriented Programming
- DRY programming

## Features
- Uses Random Number Generation to add up to 365 days to todays date.
- Validates and prompts user for input.
- Calculates difference in days between user input and randomly generated date.
- Replayable game loop.

## Logic Breakdown / Tasks
- [x] Add a random number of days to Todays Date
- [x] Prompt user for input and validate it to be positive and a number
- [x] Increment Todays Date with user input
- [x] Compare the two dates for the correct date difference between them
- [x] Check if users guess is within 5 days of the above difference

## Code Structure
- `Program.cs` - Entry point and replay loop.
- `Helper.cs` - Static class containing:
     - `PlayGame()` - Conductor method for calling private methods.
     - `SetTargetDate()` - Generates a random date.
     - `GuessAmountOfDays()` - Handles User Input.
     - `GetDateDifferenceFromUsersGuess()` - Generates a DateOnly Object using Today + Users Guess.
     - `GetDateDifferenceFromTargetAndToday()` - Gets correct number of days between Today and Target Date.
     - `DisplayResults()` - Prints win/loss messages.