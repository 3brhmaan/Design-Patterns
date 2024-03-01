namespace DesignPattern.Solid_Principles.Open_Closed_Principle;

public class ProductFilter
{
	public static IEnumerable<Product> FilterBySize(
		IEnumerable<Product> products ,
		Size size)
	{
		foreach (var product in products)
		{
			if(product.Size == size)
				yield return product;
		}
	}
	public static IEnumerable<Product> FilterByColor(
		IEnumerable<Product> products,
		Color color)
	{
		foreach (var product in products)
		{
			if (product.Color == color)
				yield return product;
		}
	}

	public static IEnumerable<Product> FilterBySizeAndColor(
		IEnumerable<Product> products,
		Color color ,
		Size size)
	{
		foreach (var product in products)
		{
			if (product.Color == color && product.Size == size)
				yield return product;
		}
	}


}