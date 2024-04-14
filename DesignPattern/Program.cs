using DesignPattern.Bridge_Pattern;
using System;


namespace DesignPattern;


internal class Program
{
    private static void Main(string[] args)
    {
        var circle = new Circle(new RasterRender() , 5f);
        circle.Draw();
    }
}
