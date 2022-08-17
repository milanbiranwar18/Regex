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
Console.WriteLine("Please Enter E-mail");
string email = Console.ReadLine();

bool mail = patterns.validateEmail(email);
if (mail)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");


//UC4
Console.WriteLine("Please Enter Mobile Number");
string mobile = Console.ReadLine();

bool mob = patterns.validateMobileNumber(mobile);
if (mob)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");

//UC5
Console.WriteLine("Please Enter Mobile Number");
string password = Console.ReadLine();

bool pass = patterns.validatePassword(password);
if (pass)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");

//UC6
Console.WriteLine("Please Enter Mobile Number");
string password6 = Console.ReadLine();

bool passw = patterns.validatePassword6(password6);
if (passw)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");


//UC7
Console.WriteLine("Please Enter Mobile Number");
string password7 = Console.ReadLine();

bool passwo = patterns.validatePassword6(password7);
if (passwo)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");


//UC8
Console.WriteLine("Please Enter Mobile Number");
string password8 = Console.ReadLine();

bool passwor = patterns.validatePassword6(password8);
if (passwor)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");


//UC9
Console.WriteLine("Please Enter Mobile Number");
string emailId = Console.ReadLine();

bool mailId = patterns.validatePassword6(emailId);
if (mailId)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");




