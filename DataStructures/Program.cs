// list

var names = new List<string>{"Scott","Ana","Felipe"};
names.Add("David");

// Sorting and Searching in a list
Console.WriteLine($"I found 99 at index {names.IndexOf("Ana")}");
names.Sort();
Console.WriteLine($"I found 99 at index {names.IndexOf("Ana")}");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Or

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!");
}

// using indexing to print the list

Console.WriteLine(names[0]);
Console.WriteLine(names[2]);
Console.WriteLine(names[^2]);
Console.WriteLine(names[^3]);

// Arrays
var cars = new string[] {"Civic","PathFinder","Elantra","Corolla"}; // Array
// adding to arrays
cars = [..cars, "Picanto"];

foreach (var car in cars)
{
    Console.WriteLine($"Hello, our cars array are: {car.ToUpper()}");
}
var numbers = new int[] {1,99,7,5,6,4,8,3}; // Array
// adding to arrays

foreach (var mumber in numbers)
{
    Console.WriteLine($"Hello, our numbers array are: {numbers}");
}
// Finding the index of 99 before sorting
int indexBeforeSort = Array.IndexOf(numbers, 99);
Console.WriteLine($"I found 99 at index {indexBeforeSort}");

// Sorting the array
Array.Sort(numbers);

// Finding the index of 99 after sorting
int indexAfterSort = Array.IndexOf(numbers, 99);
Console.WriteLine($"I found 99 at index {indexAfterSort}");
