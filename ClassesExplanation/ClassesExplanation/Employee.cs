using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExplanation
{
    public class Employee
    {
        private int age;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int theAgeTheCallerTryingToSetTheFieldTo)
        {
            if(theAgeTheCallerTryingToSetTheFieldTo < 1
                || theAgeTheCallerTryingToSetTheFieldTo > 100)
            {
                Console.WriteLine("Age must be between 1 and 100.");
                return;
            }

            age = theAgeTheCallerTryingToSetTheFieldTo;
        }
    }
}
