using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier
{
    internal class BoolUtilities
    {
        public static bool ParseBool(string answer)
        {
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            throw new ArgumentException("Cannot parse answer into a y or n.");
        }
    }
}
