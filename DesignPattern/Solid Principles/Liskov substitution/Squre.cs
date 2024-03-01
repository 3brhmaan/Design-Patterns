namespace DesignPattern.Solid_Principles.Liskov_substitution;

public class Squre : Rectangle
{
	public new int Width
	{
		set
		{
			base.Height = base.Width = value;
		}
	}

	public new int Height
	{
		set
		{
			base.Height = base.Width = value;
		}
	}
}