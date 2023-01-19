using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random die = new Random();

            //Create the array to keep track of the number of rolls
            //Create a string integer so you can store asterisks instead of numbers
            string[] totalRolls = new string[12];

            //Get user input to determine how many times the die should be rolled
            Console.WriteLine("Welcome to the dice rolling game!" + "\n");
            Console.WriteLine("How many times do you want to roll the dice? ");

            //Convert the input to an integer and save it to a variable
            int numRolls = Convert.ToInt32(Console.ReadLine());

            //Roll the die
            for (int i = 0; i < (numRolls); i++)
            {
                //generate random dice rolls between 2 and 12
                int roll = die.Next(12);
                //Add an asterisk to the array for the number that was rolled
                totalRolls[roll] += '*';
            }
            Console.WriteLine("Dice rolling results");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls." + "\n");
            //Print out the results from the array
            for (int i = 1; i < 12; i++)
            {

                Console.WriteLine((i + 1) + ": " + totalRolls[i]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Thanks for playing");
        }
    }
}

