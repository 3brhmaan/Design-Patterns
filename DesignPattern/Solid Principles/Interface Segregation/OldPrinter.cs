using System.Reflection.Metadata;

namespace DesignPattern.Solid_Principles.Interface_Segregation;

public class OldPrinter : IMachine
{
	public void Print(Document d)
	{
		//
	}

	public void Scan(Document d)
	{
		//
	}

	public void Fax(Document d)
	{
		//
	}
}