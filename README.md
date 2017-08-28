# Assignment #1: Week 35

## Software Engineering

### Exercise 1
In the following description, explain when the term account is used as an application domain concept and when as a solution domain concept:
> "Assume you are developing an online system for managing bank accounts for mobile customers. A major design issue is how to provide access to the accounts when the customer cannot establish an online connection. One proposal is that accounts are made available on the mobile computer, even if the server is not up. In this case, the accounts show the amounts from the last connected session."

### Exercise 2
A passenger aircraft is composed of several millions of individual parts and requires thousands of persons to assemble. A four-lane highway bridge is another example of complexity. The first version of Word for Windows, a word processor released by Microsoft in November 1989, required 55 person-years, resulted into 249,000 lines of source code, and was delivered 4 years late. Aircraft and highway bridges are usually delivered on time and below budget, whereas software is often not. Discuss what are, in your opinion, the differences between developing an aircraft, a bridge, and a word processor, which would cause this situation.

### Exercise 3
1. Explain the differences between software development and software engineering.
2. Describe the history behind the term 'software engineering'.
3. Explain the expression 'there is no silver bullet' in relation to software systems.

## C&#35;

Fork this repository and implement the code required for the assignments below.

### Leap Year

In the `Calculator` class you will find a method `IsLeapYear` which is already implemented.

Implement a set of unit tests in the `CalculatorIsLeapYear.cs` file, which ensure that all the following rules are verified:

1. Years before 1582 are not supported (can you answer why?)
2. Years after 9999 are not supported
3. A leap year is divisible by 4
4. A year not divisible by 4 is a common year
5. A year not divisible by 100 is a leap year
6. A year not divisible by 400 is a common year
7. Otherwise it is a leap year

A test must only ever have one assertion, but you are allowed to implement some of your tests as theories if you want.

When you have verified that all tests are passing, refactor the last three `if` statements with a one-liner starting with:

```csharp
return year % 4 ...
```

... and verify that all your tests are still green.

Finally introduce a new method called `IsFrameworkLeapYear` which uses the built-in `System.Globalization.GregorianCalendar` type to solve the problem. 

### Power Of

You need to implement the `IsPowerOf` method in the `Calculator` class.
The method should return `true` if a given `number` is a power of a given `power`.
E.g. given the number `8` and the power `2`, the method should return `true`, because 8 is 2 to the power of 3.

You should try to implement the method using *tail recursion* in lieu of a loop.

In the `CalculatorIsPowerOfTests.cs` file you will find a set of unit tests.
All tests must be green.

### Main

Implement and test the `Main` method of the `Program` class.

The main method should support two syntaxes:

1. `dotnet run leap [year]`
2. `dotnet run [number] powerof [power]`

Given an understandable command it should print out the result of running the correct `Calculator` function.

Given no arguments or something that's not understandable, it should print out an error message.

You do not need to test the exception cases of the `IsLeapYear` method.

You are *not* allowed to use `try`/`catch` and the program may only throw exceptions from the `IsLeapYear` method.

## Submitting the assignment

To submit the assignment you need to create a .pdf document using LaTeX containing the answers to the questions and a link to a public repository containing your fork of the completed code.
Upload the document to Peergrade.
