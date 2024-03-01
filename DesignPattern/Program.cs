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
			foreach (var product in productFilter.Filter
	         (
		         products , 
				 new ColorSpecification(Color.Green)))
			{
				Console.WriteLine($" - {product.Name} is Green");
			}

			Console.WriteLine("\nGreen and Large Products");
			foreach (var product in productFilter.Filter
			(
		         products,
		         new AndSpecification<Product>
		         (
			         new ColorSpecification(Color.Green) ,
			         new SizeSpecification(Size.Large)
			     )))
			{
				Console.WriteLine($" - {product.Name} is Green and Large");
			}
		}
	}
}
