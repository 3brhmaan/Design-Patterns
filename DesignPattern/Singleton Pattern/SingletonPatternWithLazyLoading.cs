using MoreLinq;


namespace DesignPattern.Singleton_Pattern.SingletonPatternWithLazyLoading
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }

    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;
        private static SingletonDatabase instance;

        public static SingletonDatabase Instance
        {
            get
            {
                if (instance is null)
                    instance = new SingletonDatabase();

                return instance;
            }
        }

        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database");

            capitals = File.ReadAllLines("capitals.txt")
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1))
                );
        }

        public int GetPopulation(string name)
        {
            if (capitals.ContainsKey(name))
                return capitals[name];
            else
                return -1;
        }
    }
}
