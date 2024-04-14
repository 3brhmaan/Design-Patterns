using System;
using DesignPattern.Adapter_Pattern.VectorRaster;
using static DesignPattern.Adapter_Pattern.GenericValueAdapter;


namespace DesignPattern;


internal class Program
{
    private static void Main(string[] args)
    {
        var v = new Vector2i(1, 2);
        var vv = new Vector2i(3, 2);

        var res = v + vv;
        Console.WriteLine(res[0]);
    }
}



