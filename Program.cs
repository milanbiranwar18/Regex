// See https://aka.ms/new-console-template for more information

using RegexAssignment;

Console.WriteLine("Wellcome to the user registration problem in regex");

Console.WriteLine("Please Enter First Name");
string pattern = Console.ReadLine();
Patterns patterns = new Patterns();
bool val = patterns.validateFirstName(pattern);
if (val)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");

