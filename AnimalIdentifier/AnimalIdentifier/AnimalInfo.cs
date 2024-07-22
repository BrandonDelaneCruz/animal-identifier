
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace AnimalIdentifier
{
    public class AnimalIdentities
    {
        public string animalName;
        public string animalType;
        public int animalAge;
        public bool isAnimalVaxxinated;
        public DateTime whenDidAnimalArrive = DateTime.Now;

        public void AnimalSheet()
        {
            Console.Clear();
            Console.WriteLine($"Pets name: {animalName}" +
                    $"\n{animalName} is a: {animalType}" +
                    $"\n{animalName} is: {animalAge}" +
                    $"\nIs {animalName} Vaxinated: {isAnimalVaxxinated}" +
                    $"\n{animalName} arrived on: {whenDidAnimalArrive}");
            AnimalIdentifierHelper.ContinueScreen();
        }
    }
}



