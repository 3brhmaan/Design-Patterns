using System.Text;

namespace DesignPattern.Builder_Pattern;

public class HTMLelement
{
    public string Name, Text;
    public List<HTMLelement> Elements = new();
    private const int indentSize = 2;

    public HTMLelement()
    {
    }

    public HTMLelement(string name, string text)
    {
        Name = name;
        Text = text;
    }

    private string ToStringImp(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indent * indentSize);

        sb.AppendLine($"{i}<{Name}>");
        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', (indent + 1) * indentSize));
            sb.AppendLine(Text);
        }

        foreach (var element in Elements)
        {
            sb.Append(element.ToStringImp(indent + 1));
        }
        sb.AppendLine($"{i}</{Name}>");

        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImp(0);
    }
}