﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class Patterns
    {       
        public static string RegexFirstName = "^[A-Z]{1,}[a-z]{2,}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexFirstName);
        }

        public static string RegexLastName = "^[A-Z]{1,}[a-z]{3,}$";
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, RegexLastName);

        }

        public static string RegexEmail = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@]{1}[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, RegexEmail);
        }

    }
}


