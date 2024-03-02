using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles.Interface_Segregation
{
	public class MultiFunctionPrinter : IPrinter , IFaxer , IScanner
	{
		public void Print(Document d)
		{
			//
		}
		public void Fax(Document d)
		{
			//
		}

		public void Scan(Document d)
		{
			//
		}
	}
}
