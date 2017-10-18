using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lecture2_ex2
{
    class MyCollection<T> : ICollection<T>
    {
        private SortedList sortedListOfSome = new SortedList();
        private List<T> listOfSome = new List<T>();
        private int n;
        const int c = 5;
        Random rnd = new Random();
        public MyCollection(int n)
        {
            this.n = n;
        }

        public MyCollection()
        {
            // TODO: Complete member initialization
        }        

        void ICollection<T>.Clear()
        {
            listOfSome.Clear();
            sortedListOfSome.Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ListCount
        {
            get { return listOfSome.Count; }
        }
        int SortedListCount
        {
            get { return sortedListOfSome.Count; }
        }
        bool ICollection<T>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        int ICollection<T>.Count
        {
            get { return listOfSome.Count+sortedListOfSome.Count; }
        }
       
        public void Copy()
        {
            double num;
            foreach (var j in listOfSome)
            {
                num = rnd.NextDouble();
                sortedListOfSome.Add(num, j);
            }
        }
        public void Add(T item)
        {
            
            if (listOfSome.Count <= 5)
            {
                listOfSome.Add(item);
            }
            else if (listOfSome.Count == 6 && sortedListOfSome.Count == 0)
            {
                Copy();
            }
            else
            {
                sortedListOfSome.Add(rnd.NextDouble(), item);
            }
            //throw new NotImplementedException();
        }
        public void ShowCollection()
        {
            Console.WriteLine("List:");
            for (int i = 0; i < listOfSome.Count; i++)
            {
                Console.WriteLine(listOfSome[i]);
            }
            Console.WriteLine("SortedList:");
            PrintKeysAndValues();
        }
        public void PrintKeysAndValues()
        {
            Console.WriteLine("-KEY-\t\t\t-VALUE-");
            for (int i = 0; i < sortedListOfSome.Count; i++)
            {
                Console.WriteLine("{0}:\t{1}", sortedListOfSome.GetKey(i), sortedListOfSome.GetByIndex(i));
            }
            Console.WriteLine();
        }

    }

    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of elements:");
            int n = Convert.ToInt32( Console.ReadLine());
            MyCollection<int> myCollection = new MyCollection<int>();
            List<int> list = new List<int>();
            SortedList sList = new SortedList();
            Random rnd = new Random();
            System.Diagnostics.Stopwatch calcTime = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                myCollection.Add(i);
            }
            calcTime.Stop();
            myCollection.ShowCollection();
            Console.WriteLine("Time:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            for (int i = 0; i < n; i++)
            {
                list.Add(i);
            }
            calcTime.Stop();
            Console.WriteLine("List Time:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            for (int i = 0; i < n; i++)
            {
                sList.Add(i,i);
            }
            calcTime.Stop();
            Console.WriteLine("SortedList Time:" + calcTime.ElapsedTicks);
        }
    }
}
