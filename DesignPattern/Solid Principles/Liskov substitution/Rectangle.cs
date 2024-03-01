using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles.Liskov_substitution
{
	public class Rectangle
	{
		public virtual int Width { get; set; }
		public virtual int Height { get; set; }
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
