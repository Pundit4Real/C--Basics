// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Strings in C# 

string firstName = "Mohammed";
string lastName = "Ali";

Console.WriteLine($"My First name is {firstName} and my last name is {lastName}");

string firstFriend = "      Silas     ";
string secondFriend = "Bansey";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"My friends are {firstFriend.Trim()} and {secondFriend}");

string fullName = $"My First name is {firstName} and my last name is {lastName}";

Console.WriteLine(fullName);
//Here a new is created with the new value but does not replace the contents of the variable
Console.WriteLine(fullName.Replace("Ali", "Pundit"));
Console.WriteLine(fullName);

Console.WriteLine("##########################33");

Console.WriteLine(fullName);
//Here the content of the variable is totaly
fullName = fullName.Replace("Mohammed","Pundit");
Console.WriteLine(fullName);
Console.WriteLine(fullName.ToUpper());
Console.WriteLine(fullName.Contains("Pundit"));
Console.WriteLine(fullName.StartsWith("Pundit"));
Console.WriteLine(fullName.Length);


