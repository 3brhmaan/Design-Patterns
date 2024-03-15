using DesignPattern.Solid_Principles.Open_Closed_Principle;
using System;
using System.Text;
using DesignPattern.Builder_Pattern;
using DesignPattern.Solid_Principles.Liskov_substitution;

namespace DesignPattern
{
	internal class Program
	{ 
		static void Main(string[] args)
        {
            // <p>hello</p>
            var hello = "hello";
            HTMLBuilder builder = new HTMLBuilder();
            builder.Append("<p>");
            builder.Append(hello);
            builder.Append("</p>");



        }
	}
}
