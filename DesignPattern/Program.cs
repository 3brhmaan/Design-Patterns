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
            HTMLBuilder builder = new HTMLBuilder();
            var words = new[] { "hello", "world" };
            
            builder.Append("<ul>");
            foreach (var word in words)
            {
                builder.Append("\n<li>");
                builder.Append(word);
                builder.Append("</li>");
            }
            builder.Append("\n");
            builder.Append("</ul>");


        }
    }
}
