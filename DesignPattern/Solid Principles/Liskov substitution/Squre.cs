namespace DesignPattern.Solid_Principles.Liskov_substitution;

public class Squre : Rectangle
{
	public override int Width
	{
		set
		{
			base.Height = base.Width = value;
		}
	}

	public override int Height
	{
		set
		{
			base.Height = base.Width = value;
		}
	}
}