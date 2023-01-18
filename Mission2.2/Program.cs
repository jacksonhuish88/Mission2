using System;

namespace Mission2._2
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator");
            Console.WriteLine();

            // Prompt for Number of Simulated Rolls
            Console.Write("How many rolls would you like to simulate? ");
            string roll = Console.ReadLine();
            int rolls = Convert.ToInt32(roll);

            // Initialize Dice Rolling Vars
            int[] total = new int[13]; // from 2 to 12
            Random random = new Random();

            // Roll Dice Specified Num of Times
            for (int i = 0; i < rolls; i++)
            {;
                int diceNum1 = random.Next(1,7);
                int diceNum2 = random.Next(1, 7);
                int diceTot = diceNum1 + diceNum2;
                total[diceTot]++;
            }

            // Print Results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine();
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine();
            Console.WriteLine("Total number of rolls = " + rolls + ".");
            Console.WriteLine();

            // Calculating Percents
            for (int i=2; i<=12;i++)
            {
                Console.Write(i + ": ");
                int percent = (int)(total[i] / (float)rolls * 100);

                for (int j = 0; j < percent; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // FINISH
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
