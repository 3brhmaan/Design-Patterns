﻿using System;
using DesignPattern.Prototype_Pattern.ICloneableApproach;

namespace DesignPattern;


internal class Program
{
    private static void Main(string[] args)
    {
        var john = new Person(new[] { "john", "switch" },
            new Address("Meet Hadid", 123));

        var jane = john.Clone() as Person;
        jane.Names[0] = "Jane";

        Console.WriteLine(john);
        Console.WriteLine(jane);
    }
}