using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_Assignment2.Models;

namespace COMP123_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram == true)
            {
                Console.WriteLine("\nPlease enter a menu option: ");                
                Console.WriteLine("(1) Show All Tweets");
                Console.WriteLine("(2) Tag Search");
                Console.WriteLine("(3) Initialize (displays 5 tweets)");
                Console.WriteLine("(4) Exit Program");
                Console.Write("Choice: ");
                string menuChoice = Console.ReadLine();
                if (menuChoice == "1")
                {
                    TweetManager.ShowAll();
                }
                else if (menuChoice == "2")
                {
                    Console.Write("\nPlease enter a tag: ");
                    string input = Console.ReadLine();
                    TweetManager.ShowAll(input);
                }
                else if (menuChoice == "3")
                {
                    TweetManager.Initialize();
                }
                else if (menuChoice == "4")
                {
                    runProgram = false;
                }                
                else
                {
                    Console.WriteLine("Please enter a valid choice.");
                }                
               
            }
        }
    }
}
