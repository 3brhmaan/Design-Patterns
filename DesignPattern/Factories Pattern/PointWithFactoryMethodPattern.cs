using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factories_Pattern.FactoryMethod;



public class Point
{
    private double x, y;

    // private
    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }

    public static class Factory
    {
        public static Point NewPolarPoint(double rho, double theta)
        {
            var x = rho * Math.Cos(theta);
            var y = rho * Math.Sin(theta);
            return new Point(x, y);
        }
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
    }
}