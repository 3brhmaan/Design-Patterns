using System;
using DesignPattern.Adapter_Pattern.VectorRaster;


namespace DesignPattern;



internal class Program
{
    private static readonly List<VectorObject> vectorObjects
        = new()
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

    public static void DrawPoint(Point p)
    {
        Console.Write(".");
    }

    private static void Draw()
    {
        foreach (var vo in vectorObjects)
        {
            foreach (var line in vo)
            {
                var pointsAdapter = new LineToPointAdapter(line);
                foreach (var point in pointsAdapter) 
                    DrawPoint(point);
            }
        }
    }

    private static void Main(string[] args)
    {
        Draw();
    }
}