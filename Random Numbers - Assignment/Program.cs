using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Random_Numbers___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        { // RC Sep 11 2023

            Random generator = new Random();
            string punctuation;
            int minimum, maximum, oldMaximum, oldMinimum, diceOne, diceTwo, round;
            double decimals, newValue, total;

            // Random Integers

            Console.Title = "Random Numbers Assignment";

            Console.WriteLine("Random Integers");
            Console.Write("Enter a Minimum value: ");
            minimum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Maximum value: ");
            maximum = Convert.ToInt32(Console.ReadLine());
            oldMaximum = maximum;
            oldMinimum = minimum;

            if (maximum < minimum)
            {
                Console.WriteLine("I've switch your minimum and maximum values as you need to search up what a minimum or maximum is.");
                Console.WriteLine($"Your new values are: minimum = {maximum} and maximum = {minimum}");
                minimum = oldMaximum;
                maximum = oldMinimum;
            }

            Console.WriteLine("5 values in that range are: ");
            for (int i = 1; i <= 5; i++)
            {
              

                if (i < 5)
                {
                    punctuation = ", ";
                }
                else
                {
                    punctuation = ".";
                }

                Console.Write(generator.Next(minimum, maximum + 1) + punctuation);

            }
            Console.WriteLine();
            Console.WriteLine();

            // Dice Roller

            diceOne = generator.Next(1,7);
            diceTwo = generator.Next(1, 7);

            Console.WriteLine("The program rolls two die.");
            Console.WriteLine($"The first roll is: {diceOne}.");
            Console.WriteLine($"The second roll is: {diceTwo}.");
            Console.WriteLine($"The sum of your rolls is {diceOne+diceTwo}.");
            Console.WriteLine();

            // Random decimal Numbers

            Console.WriteLine("Now using your minimum and maximum values from before we'll find decimal values within that range.");
            Console.Write("How many decimals should the new values round to?");
            round = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 values in that range are: ");
            for (int i = 1; i <= 3; i++)
            {
                if (i < 3)
                {
                    punctuation = ", ";
                }
                else
                {
                    punctuation = ".";
                }

                decimals = Math.Round(generator.NextDouble(),round);
                newValue = generator.Next(minimum, maximum);
                total = decimals + newValue;
                Console.Write($"{total}{punctuation}");
            }
            Console.WriteLine();
            Console.ReadLine();
        } 
    }
}
