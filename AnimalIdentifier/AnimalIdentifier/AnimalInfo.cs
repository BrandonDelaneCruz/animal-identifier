
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

        public void AnimalInformation()
        {
            Console.Clear();
            Console.WriteLine($"Pets name: {animalName}" +
                    $"\n{animalName} is a: {animalType}" +
                    $"\n{animalName} is: {animalAge}" +
                    $"\nIs {animalName} Vaxinated: {isAnimalVaxxinated}" +
                    $"\n{animalName} arrived on: {whenDidAnimalArrive}");
        }
        public void FixFormErrors()
        {
            bool response = AnimalIdentifierUtility.IsAnimalInfoCorrect();
            if (response)
            {
                bool userEditOptions = true;
                while (userEditOptions)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("1: name\n" +
                        "2: type\n" +
                        "3: age\n" +
                        "4: vaxination status\n");
                    Console.Write("\nWhich Value would you like to edit?");
                    string userResponse = Console.ReadLine();

                    switch (userResponse)
                    {
                        case "1":
                            Console.Clear();
                            Console.Write("Please enter pets name: ");
                            animalName = Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            Console.Write($"What kind of animal is {animalName}: ");
                            animalType = Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            Console.Write($"How old is {animalName}: ");
                            string age = Console.ReadLine();
                            animalAge = int.Parse(age);
                            break;
                        case "4":
                            Console.Clear();
                            Console.Write($"Is {animalName} vaxinated y/n? ");
                            string userResponse2 = Console.ReadLine();
                            isAnimalVaxxinated = BoolUtilities.ParseBool(userResponse2);
                            break;
                        default:
                            throw new ArgumentException("invalid");
                    }
                    AnimalInformation();
                    userEditOptions = AnimalIdentifierUtility.IsAnimalInfoCorrect();
                }
            }
            
        }
        
    }
   
}



