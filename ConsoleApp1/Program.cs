using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("What is your name?");
                string firstName = Console.ReadLine();
            Console.WriteLine("Hi " + firstName);
            Random random = new Random();
            int RNG = random.Next(1, 11);
            Console.WriteLine("Enter a number between 1 and 10, if you guess the correct number, you win!");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (userGuess == RNG)
                {
                    Console.WriteLine("You guessed correct!");
                    break;
                }
                else if (userGuess < RNG)
                {
                    Console.WriteLine("You guessed too low");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You guessed too high");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
