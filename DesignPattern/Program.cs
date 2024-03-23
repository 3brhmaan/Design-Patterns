using System;
using DesignPattern.Singleton_Pattern.MonostatePattern;


namespace DesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var ceo1 = new CEO();
        ceo1.Name = "Adam";
        ceo1.Age = 25;

        var ceo2 = new CEO();
        Console.WriteLine(ceo2);
    }
}