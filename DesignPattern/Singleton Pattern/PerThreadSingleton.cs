using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton_Pattern
{
    public sealed class PerThreadSingleton
    {
        private static ThreadLocal<PerThreadSingleton> threadInstance
            = new ThreadLocal<PerThreadSingleton>(
                () => new PerThreadSingleton());
        public static PerThreadSingleton Instance =>
            threadInstance.Value;

        public Guid id;
        private PerThreadSingleton()
        {
            id = Guid.NewGuid();
        }
    }
}
