using System.Reflection.Metadata;

namespace DesignPattern.Solid_Principles.Interface_Segregation;

public interface IMachine
{
	void Print(Document d);
	void Scan(Document d);
	void Fax(Document d);
}