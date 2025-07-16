// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text.RegularExpressions;



public partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your age: ");

        string input = Console.ReadLine();

        var ageChecker = new Regex(@"^\d+$");

        if (ageChecker.IsMatch(input))
        {
            Console.WriteLine("ThankYou");

        }
        else
        {
            Console.WriteLine($"This is not a valid age: {input}");
        }

        string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock, and two smoking barrels\"";

        string[] filmsDumb = films.Split(',');

        Console.WriteLine("Dumb attempt at splitting");

        foreach (string film in filmsDumb)
        {
            Console.WriteLine(film);
        }

        // var csv = new Regex(
        //    "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

        var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))"); 

        MatchCollection filmsSmart = csv.Matches(films);

        Console.WriteLine("Match films in filmsSmart");

        Console.WriteLine(filmsSmart.Count);
        foreach (Match film in filmsSmart)
        {
           
            Console.WriteLine(film.Groups[2].Value);

        }

    }
    
}