using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class Patterns
    {       
        public static string RegexFirstName = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexFirstName);
        }
    }
}


