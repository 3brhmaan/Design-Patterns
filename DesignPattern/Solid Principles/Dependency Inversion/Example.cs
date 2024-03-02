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

	public interface IRelationshipBrowser
	{
		IEnumerable<Person> FindAllChildrenOf(string name);
	}

	// Low-Level
	public class Relationships : IRelationshipBrowser
	{
		private List<(Person, Relationship, Person)> relations = new();

		public void AddParentAndChild(Person parent, Person child)
		{
			relations.Add((parent , Relationship.parent , child));
			relations.Add((child , Relationship.child , parent));
		}
		public IEnumerable<Person> FindAllChildrenOf(string name)
		{
			return relations
				.Where(r => r.Item1.name == name && r.Item2 == Relationship.parent)
				.Select(r => r.Item3);
		}
	}

	// High Level
	public class Research
	{
		public Research(IRelationshipBrowser browser)
		{
			foreach (var person in browser.FindAllChildrenOf("John"))
			{
				//
			}
		}

	}
}
