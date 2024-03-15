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
            HTMLBuilder builder = new HTMLBuilder("ul");
            builder.AddChild("li" , "hello");
            builder.AddChild("li" , "world");

            Console.WriteLine(builder);


        }
    }
}
