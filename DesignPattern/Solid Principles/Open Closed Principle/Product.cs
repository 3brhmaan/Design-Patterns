using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles.Open_Closed_Principle
{
	public class Product
	{
		public Color Color;
		public Size Size;
		public string Name;

		public Product(Color color, Size size, string name)
		{
			Color = color;
			Size = size;
			Name = name;
		}
	}
}
