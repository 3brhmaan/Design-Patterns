using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Pattern
{
    public class GenericValueAdapter
    {
        public interface IInteger
        {
            int Value { get; }
        }

        public static class Dimensions
        {
            public class Two : IInteger
            {
                public int Value => 2;
            }
            public class Three : IInteger
            {
                public int Value => 3;
            }
        }

        public class Vector<T, D> where D : IInteger, new()
        {
            protected T[] data;
            public Vector(params T[] values)
            {
                var requiredSize = new D().Value;
                data = new T[requiredSize];

                var providedSize = values.Length;
                for(int i = 0; i<Math.Min(providedSize , requiredSize); i++)
                    data[i] = values[i];
            }
            public Vector()
            {
                data = new T[new D().Value];
            }
            public T this[int index]
            {
                get => data[index];
                set => data[index] = value;
            }
        }

        public class VectorOfInt<D> : Vector<int, D>
            where D : IInteger, new()
        {
            public VectorOfInt()
            {
            }
            public VectorOfInt(params int[] values) : base(values)
            {
            }

            public static VectorOfInt<D> operator+ 
                (VectorOfInt<D>lhs , VectorOfInt<D> rhs)
            {
                var result = new VectorOfInt<D>();
                for(int i = 0; i< new D().Value; i++)
                {
                    result[i] = lhs[i] + rhs[i];
                }

                return result;
            }
        }

        public class Vector2i : VectorOfInt<Dimensions.Two>
        {
            public Vector2i()
            {
            }
            public Vector2i(params int[] values) : base(values)
            {
            }
        }
    }
}

