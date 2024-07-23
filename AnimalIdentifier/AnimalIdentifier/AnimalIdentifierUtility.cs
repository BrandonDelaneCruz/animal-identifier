using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier
{
    internal class AnimalIdentifierUtility
    {
        public static void StartScreen()
        {
            Console.Clear();
            Console.Write("Welcome to Dr.Foobars office. ");
            AnimalIdentifierUtility.ContinueScreen();
        }

        public static void ContinueScreen()
        {
            Console.WriteLine();
            Console.Write($"Press enter to continue.");
            Console.ReadLine();
        }

        public static void ExitScreen()
        {
            Console.Clear();
            Console.Write($"Press Enter to exit.");
            Console.ReadLine();
        }

        public static bool IsAnimalInfoCorrect()
        {
            Console.WriteLine("\n");
            Console.Write("Is The information Correct y/n? ");
            string UserResponce = Console.ReadLine();

            if (UserResponce == "y")
            {
                return true;
            }
            else if (UserResponce == "n")
            {
                return false;
            }

            throw new ArgumentException("Cannot parse answer into a y or n.");
        }
    }
}
