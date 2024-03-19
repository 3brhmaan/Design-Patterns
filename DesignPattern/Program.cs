using DesignPattern.Prototype_Pattern.PrototypeInheritanceV2;
using System;

namespace DesignPattern;



internal class Program
{
    private static void Main(string[] args)
    {
        var john = new Employee();
        john.Names = new string[] { "john", "switch" };
        john.Address = new Address("Meet Hadid", 123);
        john.Salary = 3000;

        var copy = john.DeepCopy();
        copy.Names[0] = "ahmed";

        Console.WriteLine(john);
        Console.WriteLine(copy);


        var e = john.DeepCopy();
        var p = john.DeepCopy<Person>();
    }
}