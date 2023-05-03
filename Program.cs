//Dice Rolling Lab

//The application asks the user to enter the number of sides for a pair of dice. 
//If you have learned about exception handling, make sure the user can only enter numbers
using System;
using System.Security.Cryptography;

bool rollAgain = true;
do
{
    int die1;
    int die2;

    Console.WriteLine("Enter the number of sides for a pair of dice.");
            
    bool success = int.TryParse(Console.ReadLine(), out int diceSides);
    if (success)
    {
        //The application prompts the user to roll the dice.
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey();

        RollDice(diceSides, out die1, out die2);

        //The application “rolls” two n-sided dice...calling the method
        //Create a static method to generate the random numbers.

        static void RollDice(int diceSides, out int die1, out int die2)
        {

            Random random1 = new Random();
            int returnValue1 = random1.Next(1, diceSides);
            die1 = returnValue1;

            Random random2 = new Random();
            int returnValue2 = random2.Next(1, diceSides);
            die2 = returnValue2;
        }

        //...displaying the results of each along with a total
        Console.WriteLine($"Die one is {die1}");
        Console.WriteLine($"Die two is {die2}");
        int diceTotal = die1 + die2;
        Console.WriteLine($"The total is {diceTotal}");

        SixSidedCombinations(diceSides, die1, die2);

        SixSidedTotals(diceTotal);

        //Create a static method for six-sided dice that...combinations

        static void SixSidedCombinations(int diceSides, int die1, int die2)
        {
            if (diceSides == 6 && die1 == 1 && die2 == 1)
            { Console.WriteLine("Snake eyes!"); }

            else if (diceSides == 6 && die1 == 1 && die2 == 2)
            { Console.WriteLine("Ace deuce!"); }

            else if (diceSides == 6 && die2 == 2 && die2 == 1)

            { Console.WriteLine("Ace deuce!"); }

            else if (diceSides == 6 && die1 == 6 && die2 == 6)
            { Console.WriteLine("Box cars!"); }

            else
            { Console.WriteLine(""); }
        }

        //Create a static method for six-sided dice that...totals
        static void SixSidedTotals(int diceTotal)
        {
            if (diceTotal == 7)
            { Console.WriteLine("Win!"); }

            else if (diceTotal == 11)
            { Console.WriteLine("Win!"); }

            else if (diceTotal == 2)
            { Console.WriteLine("Craps!"); }

            else if (diceTotal == 3)
            { Console.WriteLine("Craps!"); }

            else if (diceTotal == 12)
            { Console.WriteLine("Craps!"); }

            else
            { Console.WriteLine(""); }
        }

        //Roll again?
        Console.WriteLine("Would you like to roll again? (y/n)");
        string input = Console.ReadLine();
        rollAgain = input.ToLower() == "y";
    }
    else
    { Console.WriteLine("That is not a valid number."); }  
    
} while (rollAgain == true);
