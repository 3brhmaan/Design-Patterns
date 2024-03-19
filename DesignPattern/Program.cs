using System;
using DesignPattern.Prototype_Pattern.PrototypeInheritanceV1;

namespace DesignPattern;



internal class Program
{
    private static void Main(string[] args)
    {
        var john = new Employee(new string[] { "john", "switch" } ,
            new Address("Meet Hadid", 123) ,3000);

        var copy = john.DeepCopy();
        copy.Names[0] = "ahmed";

        Console.WriteLine(john);
        Console.WriteLine(copy);
    }
}