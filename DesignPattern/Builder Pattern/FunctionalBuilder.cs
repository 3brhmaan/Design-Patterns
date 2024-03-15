using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder_Pattern;

public class Person
{
    public string Name, Position;

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}

public sealed class PersonBuilder
{
    private readonly List<Func<Person, Person>> actions = new();

    public PersonBuilder Called(string name)
    {
        return Do(p => p.Name = name);
    }

    public PersonBuilder Do(Action<Person> action)
    {
        return AddAction(action);
    }

    public Person Build()
    {
        return actions.Aggregate(new Person(), (p, f) => f(p));
    }

    private PersonBuilder AddAction(Action<Person> action)
    {
        actions.Add(p =>
        {
            action(p);
            return p;
        });
        return this;
    }
}

public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
    {
        return builder.Do(p => p.Position = position);
    }
}