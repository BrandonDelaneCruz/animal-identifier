
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalIdentifier
{
    public class AnimalIdentities
    {
        public string animalName;
        public string animalType;
        public int animalAge;
        public bool isAnimalVaxxinated;
        public DateTime whenDidAnimalArrive = DateTime.Now;

        public void PrintAnimalInfromation()
        {
            Console.Clear();
            Console.WriteLine($"Pets name: {animalName}" +
                    $"\n{animalName} is a: {animalType}" +
                    $"\n{animalName} is: {animalAge}" +
                    $"\nIs {animalName} Vaxinated: {isAnimalVaxxinated}" +
                    $"\n{animalName} arrived on: {whenDidAnimalArrive}");
        }

        public void AllowUserToEditAnimalInformation()
        {
            bool isInfoCorrect = AnimalIdentifierUtility.IsAnimalInfoCorrect();
            if (!isInfoCorrect)
            {
                bool userIsEditingOptions = true;
                while (userIsEditingOptions)
                {
                    WriteEditAnimalOptionsToScreen();
                    string userResponse = Console.ReadLine();

                    Console.Clear();

                    DisplayCorrectFormDependingOnOptionsSelected(userResponse);

                    PrintAnimalInfromation();
                    userIsEditingOptions = AnimalIdentifierUtility.IsAnimalInfoCorrect();
                }
            }
        }

        private void WriteEditAnimalOptionsToScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(
                "1: name\n" +
                "2: type\n" +
                "3: age\n" +
                "4: vaxination status\n");
            Console.Write("\nWhich Value would you like to edit?");
        }

        private void DisplayCorrectFormDependingOnOptionsSelected(string optionSelected)
        {
            switch (optionSelected)
            {
                case "1":
                    Console.Write("Please enter pets name: ");
                    animalName = Console.ReadLine();
                    break;
                case "2":
                    Console.Write($"What kind of animal is {animalName}: ");
                    animalType = Console.ReadLine();
                    break;
                case "3":
                    Console.Write($"How old is {animalName}: ");
                    string age = Console.ReadLine();
                    animalAge = int.Parse(age);
                    break;
                case "4":
                    Console.Write($"Is {animalName} vaxinated y/n? ");
                    string userResponse2 = Console.ReadLine();
                    isAnimalVaxxinated = BoolUtilities.ParseBool(userResponse2);
                    break;
                default:
                    throw new ArgumentException("invalid");
            }
        }
        
        public void AskUserToInputInformation()
        {
            Console.Clear();
            Console.Write("Please enter pets name: ");
            string name = Console.ReadLine();
            animalName = name;

            Console.Clear();
            Console.Write($"What kind of animal is {name}: ");
            string type = Console.ReadLine();
            animalType = type;

            Console.Clear();
            Console.Write($"How old is {name}: ");
            string age = Console.ReadLine();
            animalAge = int.Parse(age);

            Console.Clear();
            Console.Write($"Is {name} vaxinated y/n? ");
            string userResponse = Console.ReadLine();
            isAnimalVaxxinated = BoolUtilities.ParseBool(userResponse);
        }
    }
}



