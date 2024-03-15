using System;
using DesignPattern.Builder_Pattern.Fluent_Builder_inheritance_with_recursive_generics;

namespace DesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var me = Person.New
            .Called("Ahmed")
            .WorksAsA("Engineer")
            .Build();

        Console.WriteLine(me);
    }
}