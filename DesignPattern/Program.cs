using System;
using DesignPattern.Factories_Pattern.FactoryMethod;

namespace DesignPattern;






internal class Program
{
    private static void Main(string[] args)
    {
        Point point = Point.Factory.NewCartesianPoint(1.0, 22.0);
        Console.WriteLine(point);
    }
}