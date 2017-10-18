using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace lecture2_ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество элементов:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Int32> listOfSome = new List<Int32>();
            ArrayList arrayListOfSome = new ArrayList();
            System.Diagnostics.Stopwatch calcTime = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("_________________");
            Console.WriteLine("List Int32:");
            for (int i = 0; i < n; i++)
            {
                listOfSome.Add(i);
            }
            calcTime.Stop();
            Console.WriteLine("Add:"+calcTime.ElapsedTicks);
            calcTime.Restart();
            listOfSome.Sort();
            calcTime.Stop();
            Console.WriteLine("Sort:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            for (int i = 0; i < n; i++)
            {
                Int32 temp = listOfSome[i];
            }
            calcTime.Stop();
            Console.WriteLine("Get:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            Console.WriteLine("_________________");
            Console.WriteLine("ArrayList Int32:");
            for (int i = 0; i < n; i++)
            {
                arrayListOfSome.Add(i);
            }
            calcTime.Stop();
            Console.WriteLine("Add:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            arrayListOfSome.Sort();
            calcTime.Stop();
            Console.WriteLine("Sort:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            foreach (var i in arrayListOfSome)
            {
                Int32 temp = Convert.ToInt32(i);
            }
            calcTime.Stop();
            Console.WriteLine("Get:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            Console.WriteLine("_________________");
            List<String> listStringOfSome = new List<String>();
            arrayListOfSome.Clear();
            Console.WriteLine("List String:");
            for (int i = 0; i < n; i++)
            {
                string str =i+"a";
                listStringOfSome.Add(str);
            }
            calcTime.Stop();
            Console.WriteLine("Add:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            listStringOfSome.Sort();
            calcTime.Stop();
            Console.WriteLine("Sort:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            for (int i = 0; i < n; i++)
            {
                String temp = listStringOfSome[i];
            }
            calcTime.Stop();
            Console.WriteLine("Get:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            Console.WriteLine("_________________");
            Console.WriteLine("ArrayList String:");
            for (int i = 0; i < n; i++)
            {
                arrayListOfSome.Add(Convert.ToString(i));
            }
            calcTime.Stop();
            Console.WriteLine("Add:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            arrayListOfSome.Sort();
            calcTime.Stop();
            Console.WriteLine("Sort:" + calcTime.ElapsedTicks);
            calcTime.Restart();
            foreach (var i in arrayListOfSome)
            {
                String temp = Convert.ToString(i);
            }
            calcTime.Stop();
            Console.WriteLine("Get:" + calcTime.ElapsedTicks);
        }
    }
}
