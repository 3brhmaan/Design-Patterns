using System;
using DesignPattern.Singleton_Pattern;


namespace DesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var t1 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"T1: {PerThreadSingleton.Instance.id}");
        });

        var t2 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"T2: {PerThreadSingleton.Instance.id}");
            Console.WriteLine($"T2: {PerThreadSingleton.Instance.id}");
        });

        Task.WaitAll(t1, t2);
    }
}