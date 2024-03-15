using System;
using DesignPattern.Builder_Pattern;

namespace DesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var person = new PersonBuilder()
            .Called("ahmed")
            .WorksAs("Developer")
            .Build();

        Console.WriteLine(person);

    }
}