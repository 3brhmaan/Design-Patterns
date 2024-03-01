using DesignPattern.Solid_Principles.Open_Closed_Principle;
using System;
using DesignPattern.Solid_Principles.Liskov_substitution;

namespace DesignPattern
{
	internal class Program
	{
		static int Area(Rectangle r) => r.Height * r.Width;
		static void Main(string[] args)
		{
			Squre sq = new Squre();
			sq.Width = 4;
			Console.WriteLine(Area(sq));

			Rectangle rec = new Squre();
			rec.Width = 4;
			Console.WriteLine(Area(rec));



		}
	}
}
