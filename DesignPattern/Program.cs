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

        var tmp = Vector3f.Create(1.5f, 5.3f, 2.4f);
        Console.WriteLine(tmp);
    }
}



