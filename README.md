# Exercise 1

## Leap Year

In the `Calculator` class you will find a method `IsLeapYear` which is already implemented.

Implement a set of unit tests in the `CalculatorIsLeapYear.cs` file, which ensure that all the following rules are verified:

1. Years less than 1582 are not supported (can you answer why?)
2. Years above 9999 are not supported
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

## Power Of

You need to implement the `IsPowerOf` method in the `Calculator` class.

In the `CalculatorIsPowerOfTests.cs` file you will find a set of unit tests.
All tests must be green to pass the exercise.

## Main

Implement and test the `Main` method of the `Program` class.

The main method should support two syntaxes:

1. `<command to run> leap [year]`
2. `<command to run> [number] powerof [power]`

Given an understandable command it should print out the result of running the correct `Calculator` function.

Given no arguments or something that's not understandable, it should print out an error message.

You do not need to test the exception cases in the `IsLeapYear` method.

You are *not* allowed to use `try`/`catch` - the program may only throw exceptions from the `IsLeapYear` method.

