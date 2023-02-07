// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var numbers = Enumerable.Range(0, 100);

foreach (var number in numbers)
{
    Console.WriteLine(FizzBuzzGame.NumberCheck(number));
}
