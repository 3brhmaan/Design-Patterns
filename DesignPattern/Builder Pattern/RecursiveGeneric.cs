﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder_Pattern.Fluent_Builder_inheritance_with_recursive_generics
{
    public class Person
    {
        public string Name;
        public string Position;
        public class Builder : PersonJobBuilder<Builder> { }
        public static Builder New => new Builder();
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
    public abstract class PersonBuulder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
    public class PersonInfoBuilder<SELF> : PersonBuulder
        where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }


}
