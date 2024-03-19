using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype_Pattern.PrototypeInheritanceV1
{
    public interface IDeepCopyable<T>
    {
        T DeepCopy();
    }

    public class Address : IDeepCopyable<Address>
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Address DeepCopy()
        {
            return new Address(StreetName, HouseNumber);
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}," +
                   $"{nameof(HouseNumber)}: {HouseNumber}";
        }
    }

    public class Person : IDeepCopyable<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person((string[])Names.Clone(),
                Address.DeepCopy());
        }

        public override string ToString()
        {
            return $"Names : {string.Join(" ", Names)}, " +
                   $"Address : {Address}";
        }
    }

    public class Employee : Person, IDeepCopyable<Employee>
    {
        public int Salary;

        public Employee(string[] names,
            Address address, int salary) : base(names, address)
        {
            Salary = salary;
        }

        public Employee DeepCopy()
        {
            return new Employee((string[])Names.Clone(),
                Address.DeepCopy(), Salary);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }
    }
}
