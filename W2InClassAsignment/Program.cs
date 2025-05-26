// See https://aka.ms/new-console-template for more information

using System;
using W2InClassAssignment;
var book1 = new Book("The Hobbit", "J.R.R Tolkien", 1937);
book1.DisplayInfo();

var student = new Student
{
    Name = "Veronika",
    Grade = 95
};
Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
Console.WriteLine($"Is passing: {student.IsPassing()}");

var engine = new Engine(450);
var car = new Car("BMW", engine);
car.Describe();

var myString = "This is my string";
Console.WriteLine($"In your string: //{myString}// there are {StringMethods.CountVowels(myString)} vowels");

