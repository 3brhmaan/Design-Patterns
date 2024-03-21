using System;
using DesignPattern.Singleton_Pattern.SingletonPatternWithLazyLoading;

namespace DesignPattern;



internal class Program
{
    private static void Main(string[] args)
    {
        var db = SingletonDatabase.Instance;
    }
}