using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPattern.Adapter_Pattern.GenericValueAdapter;

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

        public class Vector<TSelf , T, D> 
            where D : IInteger, new()
            where TSelf : Vector<TSelf , T , D> , new()
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
            public static TSelf Create(params T[] values)
            {
                var result =  new TSelf();
                result.data = values;
                return result;
            }
        }

        public class VectorOfInt<TSelf , D> : Vector<TSelf, int, D>
            where D : IInteger, new()
            where TSelf : Vector<TSelf, int , D>, new()
        {
            public VectorOfInt()
            {
            }
            public VectorOfInt(params int[] values) : base(values)
            {
            }

            public static VectorOfInt<TSelf, D> operator + 
                (VectorOfInt<TSelf, D> lhs , VectorOfInt<TSelf, D> rhs)
            {
                var result = new VectorOfInt<TSelf, D>();
                for(int i = 0; i< new D().Value; i++)
                {
                    result[i] = lhs[i] + rhs[i];
                }

                return result;
            }
        }

        public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
            where D : IInteger, new()
            where TSelf : Vector<TSelf, float , D>, new()
        {

        }

        public class Vector2i : VectorOfInt<Vector2i , Dimensions.Two>
        {
            public Vector2i()
            {
            }
            public Vector2i(params int[] values) : base(values)
            {
            }
        }

        public class Vector3f : VectorOfFloat<Vector3f , Dimensions.Three>
        {
            public override string ToString()
            {
                return $"{string.Join("," , data)}";
            }
        }
    }
}