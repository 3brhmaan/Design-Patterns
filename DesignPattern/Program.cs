using DesignPattern.Bridge_Pattern;
using System;
using System.Runtime.Serialization;
using System.Text;
using DesignPattern.Decorator_Pattern;


namespace DesignPattern;


internal class Program
{
    private static void Main(string[] args)
    {
        CodeBuilder builder = "Hello";

        builder += " World";

        Console.WriteLine(builder);
    }
}