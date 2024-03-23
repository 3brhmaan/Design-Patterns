using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton_Pattern.MonostatePattern
{
    public class CEO
    {
        private static string name;
        private static int age;

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public override string ToString()
        {
            return $"{nameof(Age)}: {Age}, {nameof(Name)}: {Name}";
        }
    }
}
