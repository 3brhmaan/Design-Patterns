using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Solid_Principles.Dependency_Inversion
{
	public enum Relationship
	{
		parent , 
		child , 
		sibling
	}

	public class Person
	{
		public string name;
	}
	// Low-Level
	public class Relationships
	{
		private List<(Person, Relationship, Person)> relations = new();

		public void AddParentAndChild(Person parent, Person child)
		{
			relations.Add((parent , Relationship.parent , child));
			relations.Add((child , Relationship.child , parent));
		}

		public List<(Person, Relationship, Person)> Relations => relations;
	}
	// High Level
	public class Research
	{
		public Research(Relationships relationships)
		{
			var relations = relationships.Relations;

			var res = relations.Where(
				r => r.Item1.name == "John" &&
				     r.Item2 == Relationship.parent);

			foreach (var relation in res)
			{
				//
			}
		}

	}
}
