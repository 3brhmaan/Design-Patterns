namespace DesignPattern.Solid_Principles.Open_Closed_Principle;

// Features
public interface ISpecification<T>
{
	bool IsSatisfied(T t);
}
public class ColorSpecification : ISpecification<Product>
{
	private Color Color;

	public ColorSpecification(Color color)
	{
		Color = color;
	}
	public bool IsSatisfied(Product p)
	{
		return p.Color == Color;
	}
}
public class SizeSpecification : ISpecification<Product>
{
	private Size size;
	public SizeSpecification(Size size)
	{
		this.size = size;
	}
	public bool IsSatisfied(Product p)
	{
		return p.Size == size;
	}
}
public class AndSpecification<T> : ISpecification<T>
{
	ISpecification<T> first , second ;
	public AndSpecification(ISpecification<T> first, ISpecification<T> second)
	{
		this.first = first;
		this.second = second;
	}
	public bool IsSatisfied(T t)
	{
		return first.IsSatisfied(t) && second.IsSatisfied(t);
	}
}

// Main Class That can be extended without Modify it 
public interface IFilter<T>
{
	IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}
public class ProductFilter : IFilter<Product>
{
	public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
	{
		foreach (var product in items)
		{
			if (spec.IsSatisfied(product))
				yield return product;
		}
	}
}