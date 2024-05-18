// See https://aka.ms/new-console-template for more information

int a = 5;
int b = 6;
int c = 4;

if ((a + b + c > 10) && (a == b)) // is true // we can use indentation or {} for the if
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second number");
}
else if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is Less than 10");
    Console.WriteLine("Or the first number is not equal to the second number.");
}
else
{
    Console.WriteLine("No response");
}

// While loops

int counter = 0;

while(counter < 5)
{
    Console.WriteLine(counter);
    counter++;
}

Console.WriteLine("****************************");
Console.WriteLine("****************************");

// Do While loops

int age = 0;

do
{
    Console.WriteLine(age);
    age++;
}while(age<25);

Console.WriteLine("****************************");

// For loops, is basically use for counting up or down

for (int i = 0; i < 5; i++) // initializatio, conditional, interation(increment)
{
    Console.WriteLine(i);
}

Console.WriteLine("#############################");
for (int i = 0; i < 6; i++)
{
    if (i==4)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Nested for loop");

for (int row = 0; row < 12; row++)
{
   for (char column = 'a'; column < 'k'; column++)
   {
    Console.WriteLine($"The cell is ({row}, {column})");
   } 
}

