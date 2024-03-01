using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles;

public class Journal
{
	private readonly List<string> entriesList = new();
	private static int count = 0;

	public int AddEntry(string text)
	{
		entriesList.Add($"{++count} : {text}");
		return count;
	}

	public void RemoveEntry(int index)
	{
		entriesList.RemoveAt(index);
	}

}

