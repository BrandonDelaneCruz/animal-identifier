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

                AnimalIdentifierUtility.StartScreen();

                animal.AskUserToInputInformation();
                animal.PrintAnimalInfromation();
                animal.AllowUserToEditAnimalInformation();
                animal.PrintAnimalInfromation();

                AnimalIdentifierUtility.ContinueScreen();
            }
        }
    }
}
