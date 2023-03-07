// See https://aka.ms/new-console-template for more information
using Greed.Domain;
using System.Collections.Generic;

Console.WriteLine("Hello, Welcome to Greed");
int diceToRoll = 0;
while (diceToRoll < 1 || diceToRoll > 6)
{
    Console.WriteLine("Please enter a number of dice to roll between 1 and 6");
    var userInput = Console.ReadLine();
    if(Int32.TryParse( userInput , out int userDiceInput)) {
        diceToRoll = userDiceInput;
    }
    else {
        Console.WriteLine("You must enter a number between 1 and 6");
    }

}

List<int> diceRolls = new List<int>();
for  (int i = 0; i < diceToRoll; i++)
{
    diceRolls.Add(randomRollGenerator.newRoll());
}


Console.WriteLine($"You rolled: {string.Join(",", diceRolls)}");
Console.WriteLine($"Your score: {ScoringCalculator.CalculateScore(diceRolls)}");

