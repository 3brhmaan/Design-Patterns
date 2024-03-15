using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder_Pattern;

public class HTMLBuilder
{
    private readonly string _rootName;
    private HTMLelement root = new();

    public HTMLBuilder(string rootName)
    {
        _rootName = rootName;
        root.Name = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        HTMLelement element = new HTMLelement(childName , childText);
        root.Elements.Add(element);
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void Clear()
    {
        root = new HTMLelement(){Name = _rootName};
    }
}