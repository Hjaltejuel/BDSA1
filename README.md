# Assignment #1: Week 35

## Introduction to Software Engineering

Solve the following exercises in the [OOSE] book: 1-6, 1-8

## C##

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

A test must only ever have one assertion, but you are allowed to implement some of you tests as theories if you want.

When you have verified that all tests are passing, replace the last three `if` statements with a one-liner starting with:

```csharp
return year % 4 ...
```

... and verify that everything still works according to the specification.

Finally introduce a new method called `IsFrameworkLeapYear` which uses the built-in `System.Globalization.GregorianCalendar` type to solve the problem. 

### Power Of

You need to implement the `IsPowerOf` method in the `Calculator` class.
The method should return `true` if a given `number` is a power of a given `power`.
E.g. given the number `8` and the power `2`, the method should return `true`, because 8 is 2 to the power of 3.

You should try to implement the method using *tail recursion* in lieu of a loop.

In the `CalculatorIsPowerOfTests.cs` file you will find a set of unit tests.
All tests must be green to pass the exercise.

### Main

Implement and test the `Main` method of the `Program` class.

The main method should support two syntaxes:

1. `dotnet run leap [year]`
2. `dotnet run [number] powerof [power]`

Given an understandable command it should print out the result of running the correct `Calculator` function.

Given no arguments or something that's not understandable, it should print out an error message.

You do not need to test the exception cases of the `IsLeapYear` method.

You are *not* allowed to use `try`/`catch` and the program may only throw exceptions from the `IsLeapYear` method.

