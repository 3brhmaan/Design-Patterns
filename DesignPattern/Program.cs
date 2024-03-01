using DesignPattern.Solid_Principles.Open_Closed_Principle;
using System;

namespace DesignPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var apple = new Product(Color.Green, Size.Small, "Apple");
			var tree = new Product(Color.Green, Size.Large, "Tree");
			var house = new Product(Color.Blue, Size.Large, "House");

			Product[] products = { apple, tree, house };
			var productFilter = new ProductFilter();

			Console.WriteLine("Green Products");
			foreach (var product in productFilter.FilterByColor(products , Color.Green))
			{
				Console.WriteLine($" - {product.Name} is Green");
			}
		}
	}
}
