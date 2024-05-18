// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// integer data types
int num1 = 18;
Console.WriteLine(num1);

int a = 2100000000;
int b = 2100000000;

long c = (long)a + (long)b; //converting the numbers a and b to long before the addition
Console.WriteLine(c.GetType());
Console.WriteLine(c);

int d = 2100000;
int e = 2100000;
long f = checked(d + e); //Throwing exception message when there is an overflow
Console.WriteLine(f);
Console.WriteLine("###########3*****************");

// double && float data types
 
 double m = 42.1;
 double n = 38.2;

 double k = m + n;
 Console.WriteLine(k);
 float i = 38.2F;
 double l = m + i;
 Console.WriteLine(l);

// Decimal data types

decimal P = 42.1m;
decimal q = 38.2m;
decimal r = P+q;
Console.WriteLine(r);
Console.WriteLine($"The answer is {r}");
 
