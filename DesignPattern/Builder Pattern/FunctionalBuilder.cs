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

public abstract class FunctionalBuilder<TSubject , TSelf>
    where TSelf : FunctionalBuilder<TSubject , TSelf>
    where TSubject : class , new()
{
    private readonly List<Func<Person, Person>> actions = new();

    public TSelf Do(Action<Person> action)
    {
        return AddAction(action);
    }

    public TSubject Build()
    {
        return actions.Aggregate(new Person(), (p, f) => f(p)) as TSubject;
    }

    private TSelf AddAction(Action<Person> action)
    {
        actions.Add(p =>
        {
            action(p);
            return p;
        });
        return (TSelf)this;
    }
}

public sealed class PersonBuilder : FunctionalBuilder<Person , PersonBuilder>
{
    public PersonBuilder Called(string name)
    {
        return Do(p => p.Name = name);
    }
}

public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
    {
        return builder.Do(p => p.Position = position);
    }
}