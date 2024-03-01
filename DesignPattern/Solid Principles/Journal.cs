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

	public void Save(string filename)
	{
		// Save Entires To File
	}

	public static Journal Load(string filename)
	{
		// Load Journal From The File Name
		return null;
	}

	public void Load(Uri uri)
	{
		// Load Journal From URI
	}



}