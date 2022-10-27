using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal static class UtilitiesClass
    {
        public static string ItemInputFormatter()
        {
            try
            {
                string userInput = Console.ReadLine();
                userInput = (char.ToUpper(userInput[0]) + userInput.Substring(1));
                return userInput;
            }
            catch
            {
                return "invalid input, please select an option from the menu";
            }
        }

        public static void Menu(Dictionary<string, decimal> menuDict)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("===================");
            menuDict = menuDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in menuDict)
            {
                Console.WriteLine($"{item.Key} ${item.Value}");
            }
            Console.WriteLine("===================");
            Console.Write("Please enter the name of the item you'd like to purchase: ");
        }

        public static bool RunAgain()
        {
            bool runAgain = true;

            Console.WriteLine("Would you like to continue [y/n]");

            while (runAgain = true)
            {
                string userInput;
                
                try
                {
                    userInput = Console.ReadLine();
                    if (userInput == "y" || userInput == "Y" || userInput == "yes" || userInput == "Yes" || userInput == "YES")
                    {
                        Console.Clear();
                        return true;
                    }
                    else if (userInput == "n" || userInput == "N" || userInput == "no" || userInput == "No" || userInput == "NO")
                    {
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }
                    Console.Clear();
                    Console.WriteLine("Invalid input. Would you like to continue [y/n]?");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");

                }
            }
            return false;
        }
    }
}
