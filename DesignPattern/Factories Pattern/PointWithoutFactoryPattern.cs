using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factories_Pattern;
public enum Coordinatedystem
{
    Cartesian, Polar
}

public class Point
{
    private double x, y;

    /// <summary>
    /// Initialize a Point from EITHER Cartesian or polar system
    /// </summary>
    /// <param name="a">x if Cartesian , rho if polar</param>
    /// <param name="b">y if Cartesian , lho if polar</param>
    /// <param name="system">to specify which system to use</param>
    public Point(double a, double b,
        Coordinatedystem system = Coordinatedystem.Cartesian)
    {
        switch (system)
        {
            case Coordinatedystem.Cartesian:
                x = a;
                y = b;
                break;
            case Coordinatedystem.Polar:
                x = a * Math.Cos(b);
                y = a * Math.Sin(b);
                break;

        }
    }
}