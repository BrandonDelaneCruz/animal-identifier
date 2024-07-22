
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace AnimalIdentifier
{
    public class AnimalIdentifierHelper
    {
        public static void AnimalIntakeForm()
        {
            while (true)
            {
                AnimalIdentities animal = new AnimalIdentities();

                Console.WriteLine();

                StartScreen();

                Console.Clear();
                Console.Write("Please enter pets name: ");
                string name = Console.ReadLine();
                animal.animalName = name;

                Console.Clear();
                Console.Write($"What kind of animal is {name}: ");
                string type = Console.ReadLine();
                animal.animalType = type;

                Console.Clear();
                Console.Write($"How old is {name}: ");
                string age = Console.ReadLine();
                animal.animalAge = int.Parse(age);

                Console.Clear();
                Console.Write($"Is {name} vaxinated y/n? ");
                string userResponse = Console.ReadLine();
                animal.isAnimalVaxxinated = BoolUtilities.YesOrNo(userResponse);

                animal.AnimalSheet();

                ContinueScreen();
            }
        }
    

       public static void StartScreen()
        {
            Console.Clear();
            Console.Write("Welcome to Dr.Foobars office. ");
            ContinueScreen();
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
    }
}
