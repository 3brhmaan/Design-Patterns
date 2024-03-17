using System;
using DesignPattern.Factories_Pattern.FactoryMethod;

namespace DesignPattern;






internal class Program
{
    private static void Main(string[] args)
    {
        Point cartesianPoint = Point.NewCartesianPoint(10, 11);
        Point polarPoint = Point.NewPolarPoint(2.5, Math.PI / 2);
    }
}