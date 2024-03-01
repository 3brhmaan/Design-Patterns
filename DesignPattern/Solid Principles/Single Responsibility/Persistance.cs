using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles
{
	public class Persistance
	{
		public void SaveToFile(Journal j, string filename)
		{
			// Save Entires of particual Journal To File
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
}
