This project is a test to show your understanding of SOLID principles and clean code in general.

Background
----------

This project is designed to aggregate and print areas of shapes that are passed to it.

The project contains three model classes - Circle, Rectangle and Square, but more could be added in the future.

Each of these model classes has relevant properties to define the applicable dimensions and a property that returns the surface area.

There is a class called AreaAggreagator that has two very different purposes 
- first is to sum the areas of a number of objects passed to it
- second is the print a list of areas based on an array of objects passed to it

Lastly, there is a Printer class that can print a message either synchronously or asynchronously.

The design of this project violates a number of the SOLID principles.

Your task is to refactor the project so that

* it no longer violates SOLID principles
* new shapes can be added regardless of how the dimensions are defined 
* aggregation will only accept shapes that have an Area property in its parameters
* aggregation not throw exceptions when null objects are present in the parameters
* aggregation can be fully unit tested
* multiple output writer implementations can be used, not just a printer
* output writing can be fully unit tested
* any code smells or bad practices are corrected
* the refactored solution passes all tests with as near as possible to complete code coverage

