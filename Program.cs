// See https://aka.ms/new-console-template for more information

using RegexAssignment;

Console.WriteLine("Wellcome to the user registration problem in regex");

//UC1
Console.WriteLine("Please Enter First Name");
string pattern = Console.ReadLine();
Patterns patterns = new Patterns();
bool val = patterns.validateFirstName(pattern);
if (val)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");


//UC2
Console.WriteLine("Please Enter Last Name");
string lastname = Console.ReadLine();

bool last = patterns.validateLastName(lastname);
if (last)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");


//UC3
Console.WriteLine("Please Enter Email");
string email = Console.ReadLine();

bool mail = patterns.validateEmail(email);
if (mail)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
