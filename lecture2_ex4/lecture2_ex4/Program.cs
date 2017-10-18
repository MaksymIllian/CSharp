using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> genericClass = new GenericClass<int>();
            List<GenericClass<int>> list = new List<GenericClass<int>>
            {
                new GenericClass<int>(3),
                new GenericClass<int>(1),
                new GenericClass<int>(2)
            };

            foreach (GenericClass<int> item in list)
                Console.WriteLine(item.Property);



            list.Sort();
            Console.WriteLine();

            foreach (GenericClass<int> item in list)
                Console.WriteLine(item.Property);

            Console.ReadKey();

        }

        public class GenericClass<T> : IComparable<GenericClass<T>>
            where T : struct, IComparable<T>
        {
            private T property;

            public T Property
            {
                get
                {
                    return property;
                }
                set
                {
                    property = value;
                }
            }

            public GenericClass()
            { }

            public GenericClass(T other)
            {
                property = other;
            }

            int IComparable<GenericClass<T>>.CompareTo(GenericClass<T> other)
            {
                return this.Property.CompareTo(other.Property);
            }
        }
    }
}