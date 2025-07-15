using System.Numerics;
using System;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Working with big integers.
var largest = ulong.MaxValue;
Console.WriteLine($"A large number {largest,40:N0}");

var atomsIntheUniverse = BigInteger.Parse("123456789012345678901234567890");
Console.WriteLine($"Estimated atoms in the universe {atomsIntheUniverse,40:N0}");


//Working with Complex numbers.
var c1 = new Complex(4, 2);
var c2 = new Complex(3, 7);
var c3 = c1 + c2;
Console.WriteLine($"{c1} added to {c2} is {c3}");

