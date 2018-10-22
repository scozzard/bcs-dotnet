# BCS: C# Test

## What was required

The main objective of this test was to create a method that returns a list of numbers from 1 to 100 along with some associated output text.

The contents on the associated output text is determined by whether it meets the following criteria:

- Where a number is a multiple of 3, set “multiple of 3” as the output text.
- where a number ends in a 6, set “ends in 6” as the output text.
- Where a number is both a multiple of 3 and ends in 6, set “multiple of 3, ends in 6” as the output text.

## What I've done

The method in question can be viewed here -> https://github.com/scozzard/bcs-dotnet/blob/master/BCS.App/Services/GetNumbers.cs.

The method has a whole bunch of associated unit tests, which can be viewed here -> https://github.com/scozzard/bcs-dotnet/blob/master/BCS.Tests/GetNumbers.Tests.cs.

The method is accessed via a service class within a console application. I chose to use a console application as it is a simple means to display the rendered output of the method. To run the console application, simply clone the repository and build the solution. NOTE: This solution was built in Visual Studio 2015.
