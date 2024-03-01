using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles.Liskov_substitution
{
	public class Rectangle
	{
		public int  Width { get; set; }
		public int Height { get; set; }
		public Rectangle() { }
		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public override string ToString()
		{
			return $"Width : {Width} , Height : {Height}";
		}
	}
}
