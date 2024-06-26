﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Pattern.VectorRaster
{
    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Start.GetHashCode(), End.GetHashCode());
        }
    }

    public class VectorObject : Collection<Line>
    {
    }

    public class VectorRectangle : VectorObject
    {
        public VectorRectangle(int x, int y, int width, int height)
        {
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
            Add(new Line(new Point(x, y), new Point(x, y + height)));
            Add(new Line(new Point(x, y + height), new Point(x + width, y + height)));
        }
    }


    public class LineToPointAdapter : IEnumerable<Point>
    {
        private static int count;
        static Dictionary<int, List<Point>> cach = new();

        public LineToPointAdapter(Line line)
        {
            var hashCode = line.GetHashCode();
            if(cach.ContainsKey(hashCode))
                return;

            Console.WriteLine(
                $"{++count}: Generating Points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}]"
            );

            var points = new List<Point>();

            var left = Math.Min(line.Start.X, line.End.X);
            var right = Math.Max(line.Start.X, line.End.X);
            var top = Math.Min(line.Start.Y, line.End.Y);
            var bottom = Math.Max(line.Start.Y, line.End.Y);
            var dx = right - left;
            var dy = line.End.Y - line.Start.Y;

            if (dx == 0)
                for (var y = top; y <= bottom; ++y)
                    points.Add(new Point(left, y));
            else if (dy == 0)
                for (var x = left; x <= right; ++x)
                    points.Add(new Point(x, top));

           cach.Add(hashCode, points);
        }

        public IEnumerator<Point> GetEnumerator() 
        {
           return cach.Values
                .SelectMany(x => x)
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
