// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Collections.Immutable;

var cities = new List<string>();

cities.Add("London");
cities.Add("Paris");
cities.Add("Milan");

Console.WriteLine("Initial List");

foreach (string city in cities)
{
    Console.WriteLine($"{city}");
}

Console.WriteLine($"The first city is {cities[0]}");

Console.WriteLine($"The last city is {cities[cities.Count - 1]}");

cities.Insert(0, "Sydney");

Console.WriteLine($"After inserting Sydney at index 0");

foreach (string city in cities)
{
    Console.WriteLine($"{city}");
}

cities.RemoveAt(1);

cities.Remove("Milan");

Console.WriteLine($"After removing two cities");

foreach (string city in cities)
{
    Console.WriteLine($"{city}");
}


var immutableCities = cities.ToImmutableList();


var newList = immutableCities.Add("Rio");


Console.Write("Immuatble list of cities: ");

foreach (string city in immutableCities)
{
    Console.Write($" {city}");
}
Console.WriteLine();

Console.Write("New list of cities: ");

foreach (string city in newList)
{
    Console.Write($" {city}");
}


