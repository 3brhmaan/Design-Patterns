using System.Reflection.Metadata;

namespace DesignPattern.Solid_Principles.Interface_Segregation;

public interface IPrinter
{
	void Print(Document d);
}
public interface IScanner
{
	void Scan(Document d);
}
public interface IFaxer
{
	void Fax(Document d);
}