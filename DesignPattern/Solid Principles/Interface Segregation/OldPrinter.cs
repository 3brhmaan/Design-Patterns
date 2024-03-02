using System.Reflection.Metadata;

namespace DesignPattern.Solid_Principles.Interface_Segregation;

public class OldPrinter : IPrinter , IFaxer
{
	public void Print(Document d)
	{
		//
	}
	public void Fax(Document d)
	{
		//
	}
}