// Object Oriented Programming in C-Sharp..

Console.WriteLine("Welcome to the OOP class");

var P1 = new Person ("Scott","Hanselman", new DateOnly(2002,8,3));
var P2 = new Person ("David","Fowler", new DateOnly(2002,9,3));

P1.Pets.Add(new Dog("Fred"));
P1.Pets.Add(new Dog("Barney"));

P2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [P1, P2];

foreach(var person in people)
{
    Console.WriteLine($"{person}");

    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"    {pet} ");
    }
}

public class Person(string firstname,string lastname,DateOnly birthday)
{

    public string First {get;} = firstname;
    public string Last {get;} = lastname;
    public DateOnly Birthday {get;} = birthday;

    public List<Pet> Pets {get;} = new();

    public override string ToString()
    {
        return $"{First} {Last}";
    }


}

public abstract class Pet(string firstname)
{
    public string First {get;} = firstname;
    public abstract string MakeNoise();

     public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }


}

public class Cat(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "meow";

}

public class Dog(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "bark" ;
}
