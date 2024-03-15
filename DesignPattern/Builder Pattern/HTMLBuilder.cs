using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder_Pattern
{
    public class HTMLBuilder
    {
        StringBuilder builder = new StringBuilder();

        public void Append(string text)
        {
            builder.Append(text);
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
